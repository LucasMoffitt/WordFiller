using System.Windows.Forms;

namespace WordFiller.Controls
{
    public sealed class ContentLabel : Label
    {
        public ContentLabel()
        {
            DoubleBuffered = true;
            AutoSize = true;
        }
    }
}
