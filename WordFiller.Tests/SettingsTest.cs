using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordFiller.Framework;

namespace WordFiller.Tests
{
    [TestClass()]
    public class SettingsTest
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void CreateSettingsAndEnsureNotNull()
        {
            Settings.CreateSettingsXMLFile();
            Assert.IsTrue(File.Exists("Settings.xml"));
        }

        [TestMethod]
        public void DeleteSettingsFileAndEnsureNull()
        {
            Settings.DestroySettingsXMLFile();

            Assert.IsFalse(File.Exists("Settings.xml"));
        }
    }
}
