using CGS_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGS_Windows
{
    public partial class sellForm : Form
    {
        Gallery gallery;
        public sellForm()
        {
            InitializeComponent();
        }
        public sellForm(Gallery gallery)
        {
            InitializeComponent();// mandatory
            this.gallery = gallery;
            this.gallery.AddCurator("c0001", "luke", "lu");
            this.gallery.AddArtist("at001","Mo", "Mo");
            this.gallery.AddArtPiece("ap001", "at001", "c0001", "NiceBook", "2020", "1000", 'D');
            MessageBox.Show("inside sellform copy constructor");
        }

        private void bn_sellForm_displayAllArtPieceInfo_Click(object sender, EventArgs e)
        {
            rtb_sellFrom_displayArtPieceInfo.Clear();
            string info = this.gallery.getAllArtPiecesInfo();
            rtb_sellFrom_displayArtPieceInfo.Text = info;
        }

        private void bn_sellForm_sell_Click(object sender, EventArgs e)

        {
            if (String.IsNullOrEmpty(tb_sellForm_PieceID.Text)||String.IsNullOrEmpty(tb_sellForm_estimate.Text))
            {
                MessageBox.Show("pieceID or estimate cannot be empty");
            }
            else
            {
                //1.verify artPieceId sellable or not
                //2.if sellable, go second half of sellArtPiece(), else save the error message to messageBox
                List<object> transactionInfo = gallery.findArtPiece(tb_sellForm_PieceID.Text, tb_sellForm_estimate.Text);
                bool successTransaction = (bool)transactionInfo[0];
                string successOrErrorMessage = (string)transactionInfo[1];
               
                if (successTransaction)
                {
                    if (MessageBox.Show("Below is the artpiece info that you want to sell:\n" + successOrErrorMessage + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string message = gallery.SellArtPiece(tb_sellForm_PieceID.Text, tb_sellForm_estimate.Text);
                        MessageBox.Show(message);
                        string saveMessage = gallery.SaveArtPiecesIntoFile();
                        MessageBox.Show(saveMessage);
                    }
                }
                else
                {
                    MessageBox.Show(successOrErrorMessage);
                }

            }
            tb_sellForm_PieceID.Clear();
            tb_sellForm_estimate.Clear();


        }

        private void bn_sellForm_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bn_sellForm_save_Click(object sender, EventArgs e)
        {

        }
    }
}
