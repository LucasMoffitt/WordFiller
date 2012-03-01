using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WordFiller.Kinect
{
    class MouseImpersonator
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
      
        private const int LeftDown = 0x02;
        private const int LeftUp = 0x04;

        private const int OffSet = 20;

        private static bool _dragging;
      
        public static void Grab(int xPos, int yPos)
        {
            if (_dragging)
            {
                Release(xPos, yPos);
            }

            _dragging = true;
            Movement.Dragging = true;
            Cursor.Hide();

            Cursor.Position = new Point(xPos, yPos + OffSet);
            mouse_event(LeftDown, (uint) xPos, (uint) yPos, 0, 0);

            var t = new Thread(CheckMouseStatus);
            t.Start();
        }

        public static void Release(int xPos, int yPos)
        {
            _dragging = false;
            Movement.Dragging = false;
            Cursor.Show();

            Cursor.Position = new Point(xPos, yPos + OffSet);
            mouse_event(LeftUp, (uint) xPos, (uint) yPos, 0, 0);
        }

        private static void CheckMouseStatus()
        {
            do
            {
                Cursor.Position = new Point(KinectSettings.movement.HandX, KinectSettings.movement.HandY + OffSet);
            } 
            while (_dragging);
        }
    }
}


