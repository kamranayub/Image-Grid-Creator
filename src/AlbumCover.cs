using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace AlbumGrid
{
    public partial class AlbumCover : UserControl
    {

        private Image _Image;

        /// <summary>
        /// The album image to paint.
        /// </summary>
        public Image CoverImage
        {
            get { return _Image; }
            set { _Image = value; }
        }

        public AlbumCover()
        {
            InitializeComponent();
        }

        private void AlbumCover_Paint(object sender, PaintEventArgs e)
        {
            Graphics Artist = e.Graphics;

            // Make it nice looking
            Artist.CompositingQuality = CompositingQuality.HighQuality;
            Artist.InterpolationMode = InterpolationMode.HighQualityBicubic;
            Artist.SmoothingMode = SmoothingMode.HighQuality;

            // Draw the cover
            Artist.DrawImage(CoverImage, 0, 0, this.Width, this.Height);

            Artist.Dispose();
        }
    }
}
