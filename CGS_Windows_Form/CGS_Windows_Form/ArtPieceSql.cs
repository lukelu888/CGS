using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CGS_Windows_Form
{
    public partial class ArtPieceSql : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LUKE-HP14;Initial Catalog=CGS;Integrated Security=True");
        public ArtPieceSql()
        {
            InitializeComponent();
        }
        void DisplayTable()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();// build in method of con object, 
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from ArtPiece";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dgv_artPiece.DataSource = dt;


            con.Close();


        }
        private void bn_addArtPiece_Click(object sender, EventArgs e)
        {
            char status;

            if (rb_onDisplay.Checked == true)
            {
                status = 'D';
            }
            else
            {
                status = 'O';
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_artPiece", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ArtPieceID", SqlDbType.NVarChar).Value = ArtpieceIDtextBox.Text;
                cmd.Parameters.AddWithValue("CuratorID", SqlDbType.VarChar).Value = txb_artPiece_curatorID.Text;
                cmd.Parameters.AddWithValue("ArtistID", SqlDbType.NVarChar).Value = txb_artPiece_artistID.Text;
                cmd.Parameters.AddWithValue("Title", SqlDbType.NVarChar).Value = txb_artPiece_title.Text;
                cmd.Parameters.AddWithValue("Year", SqlDbType.Int).Value = Convert.ToInt32(txb_artPiece_year.Text);
                cmd.Parameters.AddWithValue("Value", SqlDbType.Int).Value = Convert.ToDouble(txb_artPiece_value.Text);
                cmd.Parameters.AddWithValue("Status", SqlDbType.Char).Value = status;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Art Piece was successfully added!");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                con.Close();
                DisplayTable();
            }
        }

    }
}

