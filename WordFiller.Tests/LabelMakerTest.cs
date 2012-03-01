using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordFiller.Controls;

namespace WordFiller.Tests
{
    [TestClass()]
    public class LabelMakerTest
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

        [TestMethod]
        public void RegularLabelTest()
        {
            string content = "Text";
            int fontsize = 27;

            ContentLabel actual;
            actual = LabelMaker.RegularLabel(content, fontsize);

            Assert.AreEqual(actual.Text, "Text");
        }

        [TestMethod]
        public void DragToLabelTest()
        {
            string content = "Text";
            int fontsize = 27;

            ContentLabel actual;
            actual = LabelMaker.DragToLabel(content, fontsize);

            Assert.AreEqual(actual.Text, "____");
        }

        [TestMethod]
        public void DraggableLabelTest()
        {
            string content = "<Match>";
            int fontsize = 27;

            DraggableLabel actual;
            actual = LabelMaker.DraggableLabel(content, fontsize);

            Assert.AreEqual(actual.Text, "Match");
        }

    }
}
