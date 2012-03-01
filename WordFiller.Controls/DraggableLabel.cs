using System.Drawing;
using System.Windows.Forms;

namespace WordFiller.Controls
{
    public sealed class DraggableLabel : Label
    {
        private Point _lastPos;

        public DraggableLabel()
        {
            DoubleBuffered = true;
            AutoSize = true;
        }
        
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - _lastPos.X;
                int dy = e.Y - _lastPos.Y;
                Location = new Point(Left + dx, Top + dy);

                //int clipleft = e.X - Location.X;
                //int cliptop = e.Y - Location.Y;
                //int clipwidth = ClientSize.Width - (Width - clipleft);
                //int clipheight = ClientSize.Height - (Height - cliptop);

                //Cursor.Clip = RectangleToScreen(new Rectangle(clipleft, cliptop, clipwidth, clipheight));
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Parent = FindForm();
                _lastPos = e.Location;
                BringToFront();
                Capture = true;
                
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            Capture = false;
            base.OnMouseUp(e);
        }
    }
}
