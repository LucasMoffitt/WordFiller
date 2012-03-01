using System.Drawing;
using System.Windows.Forms;

namespace WordFiller.Controls
{
    public sealed class WordLayoutPanel : FlowLayoutPanel
    {

        public bool Isfull { get; set; }
        private int fontSize;
       
        public WordLayoutPanel()
        {
            DoubleBuffered = true;
        }

        public void StartNewContentLine(int fontsize)
        {
            var spacer = LabelMaker.RegularLabel("", fontsize);
            Controls.Add(spacer);
            SetFlowBreak(spacer, true);
            fontSize = fontsize;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            Rectangle outOfBounds = new Rectangle(0, Height - 30, Width, 30);
           
            if (e.Control.Bounds.IntersectsWith(outOfBounds))
            {
                if (!Isfull)
                {
                    Isfull = true;
                    Controls.Add(LabelMaker.RegularLabel("...", fontSize));
                }
            }
           base.OnControlAdded(e);
        }

        //DEBUG
        //Provides outline for board to show when full.
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Rectangle outOfBounds = new Rectangle(0, Height - 30, Width, 30);
        //    Pen blackPen = new Pen(Color.Green, 50);
        //    e.Graphics.DrawRectangle(blackPen, outOfBounds);
        //
        //    base.OnPaint(e);
        //}
    }
}