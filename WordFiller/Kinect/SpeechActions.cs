using Microsoft.Speech.Recognition;
using WordFiller.Framework;

namespace WordFiller.Kinect
{
    class SpeechActions
    {
        public static void Actions(RecognitionResult recognitionResult)
        {
            switch (recognitionResult.Text)
            {
                case "wordfiller move":
                    MouseImpersonator.Grab(KinectSettings.movement.HandX, KinectSettings.movement.HandY);
                    break;

                case "wordfiller drop":
                    MouseImpersonator.Release(KinectSettings.movement.HandX, KinectSettings.movement.HandY);
                    break;

                case "wordfiller mark":
                    foreach (var w in ManageWindows.Forms)
                    {
                        if (w is FrmMain)
                        {
                            (w as FrmMain).UserRequestCurrentMark();
                        }
                    }
                    break;

                case "wordfiller click":
                    MouseImpersonator.Grab(KinectSettings.movement.HandX, KinectSettings.movement.HandY);
                    MouseImpersonator.Release(KinectSettings.movement.HandX, KinectSettings.movement.HandY);
                    break;

                case "wordfiller close menu":
                    foreach (var w in ManageWindows.Forms)
                    {
                        if (w is FrmMain)
                        {
                            (w as FrmMain).CloseMenu();
                        }
                    }
                    break;
                case "wordfiller open menu":
                    foreach (var w in ManageWindows.Forms)
                    {
                        if (w is FrmMain)
                        {
                            (w as FrmMain).OpenMenu();
                        }
                    }
                    break;
            }
        }
    }
}
