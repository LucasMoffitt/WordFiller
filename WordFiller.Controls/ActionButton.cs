using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WordFiller.Controls
{
    public sealed class ActionButton : Button
    {

        [Category("Appearance")]
        [Description("Image shown on mouse hover.")]
        public Image HoverImage
        {
            get { return _hoverImage; }
            set { _hoverImage = value; }
        }

        [Category("Appearance")]
        [Description("Normal image shown.")]
        public Image DefaultImage
        {
            get { return _defaultImage; }
            set { _defaultImage = value;
                  Image = value; }
        }

        private Image _defaultImage;
        private Image _hoverImage;

        public ActionButton()
        {
            DoubleBuffered = true;

            Image = DefaultImage;
            BackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
        }
        
        protected override void OnMouseHover(EventArgs e)
        {
            Image = _hoverImage;
            base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Image = _defaultImage;
            base.OnMouseLeave(e);
        }

    }
}