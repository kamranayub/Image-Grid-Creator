using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace AlbumGrid
{
    public partial class frmMain : Form
    {

        // Grid Creator
        private GridCreator gc;
        private bool _MouseIsDown = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            if (gc != null)
            {
                // Options
                gc.GridCols = (int)nudCols.Value;
                gc.AlbumWidth = (int)nudWidth.Value;
                gc.AlbumHeight = (int)nudHeight.Value;

                // Size mode
                gc.GridSizeMode = GridCreator.SizeMode.Columns;

                gc.PopulatePanel(ref pnlGrid, this);
            }
        }

#region " Control Event Handlers "

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = browseFolder.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                txtFolderPath.Text = browseFolder.SelectedPath;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFolderPath.Text != string.Empty && Directory.Exists(txtFolderPath.Text))
            {
                gc = new GridCreator(txtFolderPath.Text);

                // Find images
                int numFiles = gc.findImages();

                // Update label
                lblProgress.Text = String.Format("Found {0} images.", numFiles.ToString());

                UpdateGrid();
            }
            else
            {
                MessageBox.Show("Please enter a valid directory!");
            }
        }

        private void pnlGrid_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(AlbumCover)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void pnlGrid_DragDrop(object sender, DragEventArgs e)
        {
            // Get source of the drag
            AlbumCover DragSource = (AlbumCover)e.Data.GetData(typeof(AlbumCover));
            int srcIndex = pnlGrid.Controls.IndexOf(DragSource);

            if (srcIndex < 0) return;

            // Location in context of panel
            Point cp = pnlGrid.PointToClient(new Point(e.X, e.Y));

            // The target cover to replace
            AlbumCover DragTarget = (AlbumCover)pnlGrid.GetChildAtPoint(new Point(cp.X, cp.Y));
            if (DragTarget == null) return;

            int tarIndex = pnlGrid.Controls.IndexOf(DragTarget);

            // Same album?
            if (srcIndex == tarIndex) return;

            Point tarPoint = DragTarget.Location;
            Point srcPoint = DragSource.Location;

            // Swap image locations
            DragSource.Location = tarPoint;
            DragTarget.Location = srcPoint;

            // Swap indices
            pnlGrid.Controls.SetChildIndex(DragSource, tarIndex);
            pnlGrid.Controls.SetChildIndex(DragTarget, srcIndex);
        }

        private void pnlColor_Paint(object sender, PaintEventArgs e)
        {
            Graphics artist = e.Graphics;
            Brush drawColor = new SolidBrush(backColors.Color);
            artist.FillRectangle(drawColor, 0, 0, pnlColor.Width, pnlColor.Height);
        }

        private void pnlColor_Click(object sender, EventArgs e)
        {
            backColors.ShowDialog();

            // Update chosen color
            pnlColor.Invalidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gc != null)
            {
                if (saveImage.ShowDialog() == DialogResult.OK)
                {
                    gc.SaveImage(saveImage.FileName, ref pnlGrid, chkBgColor.Checked, backColors.Color);
                }
            }
        }

#endregion

#region " Grid Events "

        public void Album_MouseDown(object sender, MouseEventArgs e)
        {
            _MouseIsDown = true;

            AlbumCover album = (AlbumCover)sender;

            // Preview image
            pbGrid.Image = album.CoverImage;
        }
        public void Album_MouseMove(object sender, MouseEventArgs e)
        {
            AlbumCover album = (AlbumCover)sender;

            if (_MouseIsDown)
            {
                // Start drag/drop
                album.DoDragDrop(sender, DragDropEffects.Move);
            }
            _MouseIsDown = false;
        }

#endregion     

        private void lblCredits_Click(object sender, EventArgs e)
        {
            Process.Start("http://intrepidstudios.com/projects/grid-creator/");
        }
    }
}
