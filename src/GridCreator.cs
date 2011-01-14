using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace AlbumGrid
{
    class GridCreator
    {

        #region " Properties "

        /// <summary>
        /// The size mode. Either by Columns or by Grid size.
        /// TODO: Implement usage of grid size sizing (XY).
        /// </summary>
        public enum SizeMode
        {
            Columns = 0,
            XY = 1
        }

        // Extensions to look for. Separate by ;
        private string _lookFor = "*.jpg;*.png;*.gif";
        private string _FolderPath;

        private int _numCols;
        private int _picWidth;
        private int _picHeight;

        private string[] _FileExt;
        private string[] _ImagePaths;

        private SizeMode _SizeMode;

        /// <summary>
        /// The path to look for images in
        /// </summary>
        public string FolderPath
        {
            get { return _FolderPath; }
            set { _FolderPath = value;}
        }

        /// <summary>
        /// The array of Image file paths
        /// </summary>
        public string[] ImagePaths
        {
            get { return _ImagePaths; }
            set { _ImagePaths = value; }
        }

        /// <summary>
        /// How many columns to have in the Grid
        /// </summary>
        public int GridCols
        {
            get { return _numCols; }
            set { _numCols = value; }
        }
        /// <summary>
        /// The width of an album cover
        /// </summary>
        public int AlbumWidth
        {
            get { return _picWidth; }
            set { _picWidth = value; }
        }
        /// <summary>
        /// The height of an album cover
        /// </summary>
        public int AlbumHeight
        {
            get { return _picHeight; }
            set { _picHeight = value; }
        }

        /// <summary>
        /// Gets or sets the Grid Size Mode to use.
        /// </summary>
        public SizeMode GridSizeMode
        {
            get { return _SizeMode; }
            set { _SizeMode = value; }
        }

        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="path">The folder path to look in</param>
        public GridCreator(string path)
        {
            FolderPath = path;

            _FileExt = _lookFor.Split(new char[] { ';' });
        }

        /// <summary>
        /// Finds the images by extensions in the directory and sub-directories.
        /// </summary>
        /// <returns>Returns the number of images found.</returns>
        public int findImages() {
            DirectoryInfo Dir = new DirectoryInfo(FolderPath);
            ArrayList arrFiles = new ArrayList();
            FileInfo[] Files;

            // Get the files based on the extension
            // TODO: This returns duplicates if the end extension is the same for
            // different search patterns.
            // i.e. "AlbumArt*Large.jpg;*.jpg" will return two of the same images.
            // Need to check if the path already was added.
            foreach (string ext in _FileExt)
            {
                arrFiles.AddRange(Dir.GetFiles(ext, SearchOption.AllDirectories));
            }

            Files = (FileInfo[])arrFiles.ToArray(typeof(FileInfo));

            string[] Paths = new string[Files.Length];

            // Add the files to the Image Paths
            for (int i = 0; i < Files.Length; i++)
            {
                Paths[i] = Files[i].FullName;
            }

            ImagePaths = Paths;
            return ImagePaths.Length;
        }

        /// <summary>
        /// Saves the grid as an PNG image.
        /// </summary>
        /// <param name="pathToSave">Where to save the file</param>
        /// <param name="pnl">The panel that contains AlbumCover controls.</param>
        /// <param name="drawBg">Whether or not to draw the BG color (transparency)</param>
        /// <param name="bgColor">The color to use as a background</param>
        public void SaveImage(string pathToSave, ref Panel pnl, bool drawBg, Color bgColor)
        {
            int currX = 0;
            int currY = 0;

            // Project image height based on number of albums
            int numTotal = ImagePaths.Length;
            int GridRows = (int)Math.Ceiling((double)numTotal / (double)GridCols);

            // Grid
            Image Grid = new Bitmap(GridCols * AlbumWidth, GridRows * AlbumHeight);
            
            Graphics GridMaker = Graphics.FromImage(Grid);

            // Make it look nice
            GridMaker.CompositingQuality = CompositingQuality.HighQuality;
            GridMaker.InterpolationMode = InterpolationMode.HighQualityBicubic;
            GridMaker.SmoothingMode = SmoothingMode.HighQuality;

            // Draw BG?
            if (drawBg)
            {
                GridMaker.FillRectangle(new SolidBrush(bgColor), 0, 0, Grid.Width, Grid.Height);
            }

            // Go through the AlbumCover controls
            for (int i = 0; i < pnl.Controls.Count;i++ )
            {
                
                AlbumCover album = (AlbumCover)pnl.Controls[i];

                if (album != null)
                {
                    Image img = album.CoverImage;

                    GridMaker.DrawImage(img, currX, currY, AlbumWidth, AlbumHeight);

                    currX += AlbumWidth;

                    if (currX == (GridCols * AlbumWidth))
                    {
                        // End of the row
                        currX = 0;
                        currY += AlbumHeight;
                    }
                }
            }

            GridMaker.Dispose();

            Grid.Save(pathToSave);
        }

        /// <summary>
        /// Populates the Panel control with AlbumCover controls.
        /// 
        /// TODO: Keep organization/order of images when updating the panel.
        /// </summary>
        /// <param name="pnl">The reference panel</param>
        /// <param name="frm">The calling form</param>
        public void PopulatePanel(ref Panel pnl, frmMain frm)
        {
            pnl.Controls.Clear();

            int currX = 0;
            int currY = 0;

            // Add items
            for (int i = 0; i < ImagePaths.Length;i++ )
            {
                AlbumCover album = new AlbumCover();
                album.Width = AlbumWidth;
                album.Height = AlbumHeight;

                album.CoverImage = Image.FromFile(ImagePaths[i]);

                album.Location = new Point(currX, currY);

                currX += AlbumWidth;

                // This is probably not how you want to assign event handlers...
                album.MouseDown += new MouseEventHandler(frm.Album_MouseDown);
                album.MouseMove += new MouseEventHandler(frm.Album_MouseMove);

                if (currX == (GridCols * AlbumWidth))
                {
                    // End of the row
                    currX = 0;
                    currY += AlbumHeight;
                }

                // Add the control
                pnl.Controls.Add(album);
            }
        }
    } // GridCreator
}
