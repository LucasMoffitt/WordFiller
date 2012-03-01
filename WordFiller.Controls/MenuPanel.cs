using System.Drawing;
using System.Windows.Forms;

namespace WordFiller.Controls
{
    public sealed class MenuPanel : Panel
    {
        private string menuStatus = "closed";

        private Timer _movementTimer;
        private ActionButton _btnMenu;

        private const int heightMin = 105;
        private const int heightMax = 400;

        public MenuPanel()
        {
            DoubleBuffered = true;
            
            //Timer
            _movementTimer = new Timer
                                 {
                                     Interval = 1
                                 };
            _movementTimer.Tick += (movementTimer_Tick);
            
            //Menu Button
            _btnMenu = new ActionButton
                           {
                               Width = 100,
                               Height = 100,
                               DefaultImage = Properties.Resources.menu_down_default,
                               HoverImage = Properties.Resources.menu_down_hover,
                               BackColor = Color.Transparent,
                               ImageAlign = ContentAlignment.MiddleCenter,
                           };
            _btnMenu.Click += (_btnMenu_Click);
            Controls.Add(_btnMenu);
        }

        protected override void OnResize(System.EventArgs eventargs)
        {
            _btnMenu.Location = new Point((Width - 130), 7);
            base.OnResize(eventargs);
        }

        private void _btnMenu_Click(object sender, System.EventArgs e)
        {
            ToggleMenu();
        }
        
        public void ToggleMenu()
        {
            switch (menuStatus)
            {
                case "open":
                    CloseMenu();
                    break;

                case "closed":
                    OpenMenu();
                    break;
            }
        }

        private void movementTimer_Tick(object sender, System.EventArgs e)
        {
            switch (menuStatus)
            {
                case "open":
                    Height = Height + 8;
                    CheckOverflow();
                    break;

                case "closed":
                    Height = Height - 8;
                    CheckOverflow();
                    break;
            }
        }

        public void OpenMenu()
        {
            _btnMenu.DefaultImage = Properties.Resources.menu_up_default;
            _btnMenu.HoverImage = Properties.Resources.menu_up_hover;
            menuStatus = "open";
            _movementTimer.Enabled = true;
            BringToFront();
        }

        public void CloseMenu()
        {
            _btnMenu.DefaultImage = Properties.Resources.menu_down_default;
            _btnMenu.HoverImage = Properties.Resources.menu_down_hover;
            menuStatus = "closed";
            _movementTimer.Enabled = true;
        }

        private void CheckOverflow()
        {
            if (Height <= heightMin)
            {
                _movementTimer.Enabled = false;
                Height = heightMin;
                menuStatus = "closed";
                BringToFront();
            }

            if (Height >= heightMax)
            {
                _movementTimer.Enabled = false;
                Height = heightMax;
                menuStatus = "open";
                BringToFront();
            }
        }

        public void MakeReady()
        {
            Height = heightMin;
        }

     }
}
