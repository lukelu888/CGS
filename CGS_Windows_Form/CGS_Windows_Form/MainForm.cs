using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGS_Lib;
//using static CGS_Lib.Constants;
namespace CGS_Windows
{
    public partial class MainForm : Form
    {
        Gallery gallery = new Gallery();

       
        public MainForm()
        {
            InitializeComponent();
        }

        private void bn_addCurator_Click(object sender, EventArgs e)
        {
            string message = gallery.AddCurator(txb_curatorID.Text, txb_curator_fname.Text, txb_curator_lname.Text);
            MessageBox.Show(message);
            txb_curatorID.Clear();
            txb_curator_fname.Clear();
            txb_curator_lname.Clear();
        }



        private void bn_viewCurator_Click(object sender, EventArgs e)
        {
            rtb_main.Clear();
            string info = gallery.getAllCuratorsInfo();
            rtb_main.AppendText(info);
        
        }

        private void bn_addArtist_Click(object sender, EventArgs e)
        {
            string message = gallery.AddArtist(txb_artistID.Text, txb_artist_fname.Text, txb_artist_lname.Text);
            MessageBox.Show(message);
            txb_artist_fname.Clear();
            txb_artist_lname.Clear();
            txb_artistID.Clear();
        }

        private void bn_viewArtists_Click(object sender, EventArgs e)
        {
            rtb_main.Clear();
            string info = gallery.getAllArtistsInfo();
            rtb_main.AppendText(info);
        }

        private void bn_sellArtpiece_Click(object sender, EventArgs e)
        {
            //this.Hide();
            sellForm sellForm = new sellForm(gallery);
            sellForm.ShowDialog();
        }

        private void bn_addArtPiece_Click(object sender, EventArgs e)
        {
            char status;
            if (rb_inStorage.Checked)
            {
                status = 'O';
            }
            else {
                status = 'D';
            }


            string message = gallery.AddArtPiece(txb_artPiece_pieceID.Text,txb_artPiece_artistID.Text,txb_artPiece_curatorID.Text,txb_artPiece_title.Text,txb_artPiece_year.Text,txb_artPiece_value.Text,status );
            MessageBox.Show(message);
            txb_artPiece_pieceID.Clear();
            txb_artPiece_artistID.Clear();
            txb_artPiece_curatorID.Clear();
            txb_artPiece_title.Clear();
            txb_artPiece_year.Clear();
            txb_artPiece_value.Clear();
            rb_inStorage.Checked = false;
            rb_onDisplay.Checked = false;
        }

        private void bn_listArtPieces_Click(object sender, EventArgs e)
        {
            rtb_main.Clear();
            string info = gallery.getAllArtPiecesInfo();
            rtb_main.AppendText(info);
        }
        private void bn_saveCurator_Click(object sender, EventArgs e)
        {
            string message = gallery.SaveCuratorsIntoFile();
            MessageBox.Show(message);
        }

        private void bn_artists_saveArtists_Click(object sender, EventArgs e)
        {
            string message = gallery.SaveArtistsIntoFile();
            MessageBox.Show(message);
        }

        private void bn_artPiece_saveArtPieces_Click(object sender, EventArgs e)
        {
            string message = gallery.SaveArtPiecesIntoFile();
            MessageBox.Show(message);
        }

        private void bn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void tabCurators_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Curators");
        //    statusStrip_mainForm.Text = "Curators";
        //}

        //private void tabArtists_Click(object sender, EventArgs e)
        //{
        //    statusStrip_mainForm.Text = "Artists";
        //}

        //private void tabArtPieces_Click(object sender, EventArgs e)
        //{
        //    statusStrip_mainForm.Text = "Art Pieces";
        //}



        private void tabCurators_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text= "Curators";
        }

        private void tabArtists_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Artists";
        }

        private void tabArtPieces_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Art Pieces";
        }

        private void tabArtists_MouseHover_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Artists";
        }

        private void tabArtPieces_MouseHover_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Art Pieces";
        }

        private void bn_curators_appendCuratorInFile_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txb_curatorID.Text)|| String.IsNullOrEmpty(txb_curator_fname.Text)||String.IsNullOrEmpty(txb_curator_lname.Text))
            {
                MessageBox.Show("curatorId or curator first name or curator last name cannot be empty!");
            }
            else
            {
                string message = gallery.appendCuratorInFile(txb_curatorID.Text);
                MessageBox.Show(message);
            }
        }

        private void bn_curators_updateCuratorInFile_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txb_curatorID.Text) || String.IsNullOrEmpty(txb_curator_fname.Text) || String.IsNullOrEmpty(txb_curator_lname.Text))
            {
                MessageBox.Show("curatorId or curator first name or curator last name cannot be empty!");
            }
            else
            {
                string message = gallery.updateCuratorInFile(txb_curatorID.Text, txb_curator_fname.Text, txb_curator_lname.Text);
                MessageBox.Show(message);
            }
        }

        private void bn_curators_updateCuratorInFileV2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txb_curatorID.Text) || String.IsNullOrEmpty(txb_curator_fname.Text) || String.IsNullOrEmpty(txb_curator_lname.Text))
            {
                MessageBox.Show("curatorId or curator first name or curator last name cannot be empty!");
            }
            else
            {
                string message = gallery.updateCuratorInFileV2(txb_curatorID.Text, txb_curator_fname.Text, txb_curator_lname.Text);
                MessageBox.Show(message);
            }
        }

        private void bn_artPiece_saveArtPiece_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip_mainForm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabArtists_Click(object sender, EventArgs e)
        {

        }

        private void rb_onDisplay_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
