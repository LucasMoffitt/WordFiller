using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordFiller.Framework;

namespace WordFiller.Tests
{
    [TestClass()]
    public class LibraryTest
    {

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        public string resourceTitle = "Test Resource";
        public string resourceContent = "Here is some content for the <resource>.";

        [TestMethod]
        public void WrapInBracketsTest()
        {
            string word = "word";
            string actual = Library.WrapInBrackets(word);

            Assert.AreEqual(actual, "<word>");
        }
        
        [TestMethod]
        public void IsWordWrappedInBracketsTestReturnTrue()
        {
            string word = "<word>";

            bool actual;
            actual = Library.IsWordWrappedInBrackets(word);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsWordWrappedInBracketsReturnFalse()
        {
            string word = "word";

            bool actual;
            actual = Library.IsWordWrappedInBrackets(word);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CreateLibraryAndEnsureNotNull()
        {
            Library.CreateLibrary();
            Assert.IsTrue(Directory.Exists("library"));
        }

        [TestMethod]
        public void CreateAResource()
        {
            Library.SaveResource(resourceTitle, resourceContent);
            var resourceLocation = (Library.LibraryLocation + resourceTitle + ".txt");

            Assert.IsTrue(File.Exists(resourceLocation));
        }

        [TestMethod]
        public void DeleteAResource()
        {
            CreateAResource();

            Library.DeleteResource(resourceTitle);
            var resourceLocation = (Library.LibraryLocation + resourceTitle + ".txt");

            Assert.IsFalse(File.Exists(resourceLocation));
        }
    }
}
