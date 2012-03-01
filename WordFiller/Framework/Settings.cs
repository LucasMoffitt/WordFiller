using System;
using System.Linq;
using System.IO;
using System.Xml.Linq;

namespace WordFiller.Framework
{
    public class Settings
    {
        private static readonly string _SettingsFile = @"settings.xml";

        public static bool DoSettingsExist
        {
            get { return File.Exists(_SettingsFile); }
        }

        public static void CreateSettingsXMLFile()
        {
            XDocument settings = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("DO NOT EDIT - This file is maintained by WordFiller, manual changes will damage customised settings"),
                new XElement("wordfiller",
                             new XComment("General Settings Used by WordFiller"),
                             new XElement("generalsettings",
                             new XElement("textsize", "27")),
                             new XComment("Settings Used by the Kinect"),
                             new XElement("kinectsettings",
                             new XElement("kinectenabled", "false"),
                             new XElement("kinectlanguage", "SR_MS_en-US_Kinect_10.0"),
                             new XElement("handorientation", "right"))));

            WriteSettings(settings);
        }

        public static void DestroySettingsXMLFile()
        {
            if (DoSettingsExist)
            {
                File.Delete(_SettingsFile);
            }
        }
        
        public static int GetFontSize()
        {
            var textSize = ReadSettings().Descendants("textsize").FirstOrDefault();

            if (textSize == null)
                return -1;

            int value;
            if (!int.TryParse(textSize.Value, out value))
            {
                return -1;
            }

            return value;
        }

        public static void SetFontSize(int size)
        {
            var settingsFile = ReadSettings();
            var textSize = settingsFile.Descendants("textsize").FirstOrDefault();

            if (textSize != null)
            {
                textSize.SetValue(size);
            }

            WriteSettings(settingsFile);
        }

        public static bool GetKinectStatus()
        {
            var kinectStatus = ReadSettings().Descendants("kinectenabled").FirstOrDefault();

            if (kinectStatus == null)
                return false;

            bool status = Convert.ToBoolean(kinectStatus.Value);
            return status;
        }
        public static void SetKinectStatus(bool status)
        {
            var settingsFile = ReadSettings();
            var kinectStatus = settingsFile.Descendants("kinectenabled").FirstOrDefault();

            if (kinectStatus != null)
            {
                kinectStatus.SetValue(status);
            }

            WriteSettings(settingsFile);
        }

        public static string GetKinectLanguage()
        {
            var kinectLanguage = ReadSettings().Descendants("kinectlanguage").FirstOrDefault();

            //Hardcoding in US language pack as failback default
            if (kinectLanguage == null)
                return "SR_MS_en-US_Kinect_10.0";

            var language = kinectLanguage.Value;

            return language;
        }

        //Not Implemented Yet
        public static void SetKinectLanguage(string language)
        {
            var settingsFile = ReadSettings();
            var kinectLanguage = settingsFile.Descendants("kinectlanguage").FirstOrDefault();

            if (kinectLanguage!= null)
            {
                kinectLanguage.SetValue(language);
            }

            WriteSettings(settingsFile);
        }

        public static string GetHandOrientation()
        {
            var handOrientation = ReadSettings().Descendants("handorientation").FirstOrDefault();

            if (handOrientation == null)
            {
                DestroySettingsXMLFile();
                CreateSettingsXMLFile();
                GetHandOrientation();
            }

            var orientation = handOrientation.Value;

            return orientation;
        }
        
        public static void SetHandOrientation(string hand)
        {
            var settingsFile = ReadSettings();
            var handOrientation = settingsFile.Descendants("handorientation").FirstOrDefault();

            if (handOrientation != null)
            {
                handOrientation.SetValue(hand);
            }

            WriteSettings(settingsFile);
        }      

        private static XDocument ReadSettings()
        {
            return XDocument.Load(_SettingsFile);
        }

        private static void WriteSettings(XDocument settings)
        {
            settings.Save(_SettingsFile);
        }
        
    }
}
