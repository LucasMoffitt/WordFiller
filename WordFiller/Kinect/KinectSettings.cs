﻿using System;
using System.Drawing;
using System.Linq;
using Microsoft.Speech.AudioFormat;
using Microsoft.Speech.Recognition;
using System.Threading;
using Coding4Fun.Kinect.WinForm;
using Microsoft.Research.Kinect.Nui;
using Microsoft.Research.Kinect.Audio;
﻿using WordFiller.Framework;

namespace WordFiller.Kinect
{
    class KinectSettings
    {
        public static Runtime Nui;
        public static Image videoOutput;

        private static KinectAudioSource kinectSource;
        private static SpeechRecognitionEngine speechRecognitionEngine;
        private static readonly string RecognizerId = Settings.GetKinectLanguage();
        private const double LanguageConfidence = 0.7;

        private static bool draggingWithHandGesture;
        public static Movement movement = new Movement();

        private static bool IsKinectConnected()
        {
            return Runtime.Kinects.Count != 0;
        }

        public static void DisableKinect()
        {
            if (Nui != null)
            {
                Nui.Uninitialize();
            }

            if (speechRecognitionEngine != null)
            {
                speechRecognitionEngine.RecognizeAsyncCancel();
                speechRecognitionEngine.RecognizeAsyncStop();
                kinectSource.Dispose();
            }
        }

        public static void TiltKinect(int elevation)
        {
            try
            {
                Nui.NuiCamera.ElevationAngle = elevation;
            }
            catch (Exception)
            {
                //We can't really do much with it because the Kinect can sometimes be a goose.
            }
        }

        public static void EnableKinect()
        {
            if (IsKinectConnected())
            {
                Nui = Runtime.Kinects[0];

                Nui.Initialize(RuntimeOptions.UseColor | RuntimeOptions.UseSkeletalTracking);

                Nui.VideoFrameReady += nui_VideoFrameReady;
                Nui.SkeletonFrameReady += nui_SkeletonFrameReady;

                OpenKinectVideoStream();
                SetupSpeechRecognitionRules();
                EnableSmoothSkeleton();
            }
        }

        private static void StartKinectAudioSettingsThread()
        {
            var t = new Thread(KinectAudioSettings);
            t.Start();
        }

        private static void KinectAudioSettings()
        {
            kinectSource = new KinectAudioSource
            {
                SystemMode = SystemMode.OptibeamArrayOnly,
                FeatureMode = true,
                AutomaticGainControl = false,
                MicArrayMode = MicArrayMode.MicArrayAdaptiveBeam
            };

            var kinectStream = kinectSource.Start();
            speechRecognitionEngine.SetInputToAudioStream(kinectStream,
                    new SpeechAudioFormatInfo(EncodingFormat.Pcm,
                    16000, 16, 1,
                    32000, 2, null));


            speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private static void SetupSpeechRecognitionRules()
        {
            RecognizerInfo ri = SpeechRecognitionEngine.InstalledRecognizers()
                .Where(r => r.Id == RecognizerId).FirstOrDefault();

            if (ri == null) return;

            speechRecognitionEngine = new SpeechRecognitionEngine(ri.Id);

            var commands = SpeechCommands.Commands();

            var gb = new GrammarBuilder();

            gb.Culture = ri.Culture;
            gb.Append(commands);

            var g = new Grammar(gb);

            speechRecognitionEngine.LoadGrammar(g);
            speechRecognitionEngine.SpeechRecognized += SpeechRecognitionEngineSpeechRecognized;
            StartKinectAudioSettingsThread();
        }

        static void SpeechRecognitionEngineSpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            RecognitionResult recognitionResult = e.Result;

            if (recognitionResult.Confidence > LanguageConfidence)
            {
                SpeechActions.Actions(recognitionResult);
            }
        }

        private static void OpenKinectVideoStream()
        {
            Nui.VideoStream.Open(ImageStreamType.Video,
                                 2,
                                 ImageResolution.Resolution640x480,
                                 ImageType.Color);
        }

        private static void EnableSmoothSkeleton()
        {
            Nui.SkeletonEngine.TransformSmooth = true;

            var parameters = new TransformSmoothParameters
            {
                Smoothing = 0.75f,
                Correction = 0.0f,
                Prediction = 0.0f,
                JitterRadius = 0.05f,
                MaxDeviationRadius = 0.04f
            };

            Nui.SkeletonEngine.SmoothParameters = parameters;
        }

        private static void nui_VideoFrameReady(object sender, ImageFrameReadyEventArgs e)
        {
            videoOutput = e.ImageFrame.ToBitmap();
        }

        private static void nui_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            SkeletonFrame allskeletons = e.SkeletonFrame;

            var skeletonData = (from s in allskeletons.Skeletons
                                where s.TrackingState == SkeletonTrackingState.Tracked
                                select s).FirstOrDefault();

            if (skeletonData == null) return;

            switch (Settings.GetHandOrientation())
            {
                case "left":
                    SetHandPosition(skeletonData.Joints[JointID.HandLeft]);
                    CheckRaisedHand(skeletonData.Joints[JointID.HandRight], skeletonData.Joints[JointID.Head]);

                    break;
                case "right":
                    SetHandPosition(skeletonData.Joints[JointID.HandRight]);
                    CheckRaisedHand(skeletonData.Joints[JointID.HandLeft], skeletonData.Joints[JointID.Head]);
                    break;
            }
        }

        private static void SetHandPosition(Joint joint)
        {
            var scaledJoint = joint.ScaleTo(movement.ViewWidth, movement.ViewHeight, 0.3f, 0.3f);


            movement.HandX = (int)scaledJoint.Position.X;
            movement.HandY = (int)scaledJoint.Position.Y;
        }

        private static void CheckRaisedHand(Joint hand, Joint head)
        {
            //     if the arm is above the head on the y axis click

            if (hand.Position.Y > head.Position.Y)
            {
                draggingWithHandGesture = true;
                MouseImpersonator.Grab(movement.HandX, movement.HandY);
                return;
            }

            if (head.Position.Y > hand.Position.Y && draggingWithHandGesture == true)
            {
                draggingWithHandGesture = false;
                MouseImpersonator.Release(movement.HandX, movement.HandY);
                return;
            }
            draggingWithHandGesture = false;
        }
    }
}