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
    public partial class SellFormSql : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LUKE-HP14;Initial Catalog=CGS;Integrated Security=True");
        public SellFormSql()
        {
            InitializeComponent();
        }

        private void DisplayArtPiece()
        {
            string query = "SELECT * FROM ArtPiece";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv_sell_artPiece.DataSource = ds.Tables[0];
        }

        private void DisplayCurator()
        {
            string query = "SELECT * FROM Curator";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv_sell_curator.DataSource = ds.Tables[0];
        }
        private void bn_sellSql_displayArtPiece_Click(object sender, EventArgs e)
        {
            DisplayArtPiece();
        }
    

        private void bn_sellSql_displayCurator_Click(object sender, EventArgs e)
        {
            DisplayCurator();

        }

        private void bn_sellSql_sell_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_sellSql_artPieceId.Text))
            {
                MessageBox.Show("Art Piece ID cannot be empty!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select curatorID, value from ArtPiece where ArtPieceID ='" + tb_sellSql_artPieceId.Text + "'", con);
                    //string curatorID = (string)cmd.ExecuteScalar();//return first column of first row
                 



                    SqlDataReader reader; // read one row
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        tb_sellSql_value.Text = reader["Value"].ToString();
                        string curatorID = reader["curatorID"].ToString();
                        reader.Close();
                        if (String.IsNullOrEmpty(tb_sellSql_estimate.Text))
                        {
                            MessageBox.Show("Estimate cannot be empty to sell!");
                        }
                        else
                        {
                            if (Convert.ToDouble(tb_sellSql_estimate.Text) > Convert.ToDouble(tb_sellSql_value.Text))
                            {
                                //update status of art Piece,
                                //update commission for curator,
                                // update dgv for artpiece and curator


                                SqlCommand cmdUpdate = con.CreateCommand();
                                cmdUpdate.CommandType = CommandType.Text;
                                string stmt = "Update ArtPiece set status='S' where ArtPieceID = '"+ tb_sellSql_artPieceId.Text + "'";
                                cmdUpdate.CommandText = stmt;
                                cmdUpdate.ExecuteNonQuery();

                                DisplayArtPiece();



                                double commission=(Convert.ToDouble(tb_sellSql_estimate.Text)- Convert.ToDouble(tb_sellSql_value.Text))*0.25;
                                MessageBox.Show("Update Curator set commission='" + commission + "' where CuratorID = '" + curatorID + "'");
                                cmdUpdate.CommandText = "Update Curator set commission+='" + commission + "' where CuratorID = '" + curatorID+"'";
                                cmdUpdate.ExecuteNonQuery();
                                DisplayCurator();








                            }
                        }

                        
                    }
                    else
                    {
                        tb_sellSql_value.Text = "Sorry!not found";
                    }
                }
                catch (Exception ex) 
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
               

               
            }
            

        }

        private void bn_sellSql_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
