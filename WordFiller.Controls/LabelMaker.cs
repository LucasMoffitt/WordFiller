using System.Text;
using System.Windows.Forms;
using System.Drawing;
using WordFiller.Controls;

namespace WordFiller
{
    public static class LabelMaker
    {
        public static ContentLabel RegularLabel(string content, int fontsize)
        {
            return new ContentLabel
                       {
                           Text = content.Trim(),
                           ForeColor = Color.Black,
                           BackColor = Color.Transparent,
                           Font = new Font("Arial", fontsize, FontStyle.Regular, GraphicsUnit.Point, 0),
                       };
        }

        public static ContentLabel DragToLabel(string content, int fontsize)
        {
            var replacement = new StringBuilder("");
            foreach (char character in content)
            {
                replacement.Append("_");
            }

            return new ContentLabel
                       {
                           Text = replacement.ToString().Trim(),
                           ForeColor = Color.Black,
                           BackColor = Color.Transparent,
                           Font = new Font("Arial", fontsize, FontStyle.Regular, GraphicsUnit.Point, 0),
                       };
        }
       
        public static DraggableLabel DraggableLabel(string content, int fontsize)
        {
            return new DraggableLabel
                       {
                           Text = content.Trim('<', '>', ' ', '.', ',', '"'),
                           Font = new Font("Arial", fontsize, FontStyle.Regular, GraphicsUnit.Point, 0),
                           ForeColor = Color.White,
                           BackColor = Color.FromArgb(72, 136, 239),
                           Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
                       };
        }
    }
}