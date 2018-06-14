using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{
    public class PanelButton:Panel
    {
        public Image HoverImage { get; set; }
        public Image NormalImage
        {
            get { return _normalImage; }
            set
            {
                this._normalImage = value;
                this.BackgroundImage = value;
            }
        }
        private Image _normalImage;
        public Image DownImage { get; set; }
        public PanelButton()
        {
            this.Size = new System.Drawing.Size(50, 50);
            this.Cursor = Cursors.Hand;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackgroundImage = this.HoverImage;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackgroundImage = this.NormalImage;

            base.OnMouseLeave(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {

            this.BackgroundImage = DownImage;

            base.OnMouseClick(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.BackgroundImage = this.NormalImage;

            base.OnMouseUp(e);
        }
    }
}
