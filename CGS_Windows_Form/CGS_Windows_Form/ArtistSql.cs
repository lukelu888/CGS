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
    public partial class ArtistSql : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LUKE-HP14;Initial Catalog=CGS;Integrated Security=True");
        public ArtistSql()
        {
            InitializeComponent();
        }

        void DisplayTable()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from artist";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dgv_artist.DataSource = dt;


            con.Close();





        }
        private void bn_addArtist_Click(object sender, EventArgs e)
        {
            



            // we can set not null in database , so dont need to check null here
            // BUT WE NEED TO CHECK EMPTY HERE,  even if empty, because it's not null, so sql server will still accept it


/*            
            if (String.IsNullOrEmpty(tb_artist_artistId.Text) || String.IsNullOrEmpty(tb_artist_curatorId.Text) || String.IsNullOrEmpty(tb_artist_fname.Text) || String.IsNullOrEmpty(tb_artist_lname.Text)|| tb_artist_artistId.Text.Length != 5 || tb_artist_curatorId.Text.Length != 5|| (tb_artist_fname.Text.Length + tb_artist_lname.Text.Length)>40)
            {
                MessageBox.Show("Error:fields cannot be empty and artistID and curatorID must be 5 digit!, and first name last name total cannot be more than 40 chars!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Artist values ('" + tb_artist_artistId.Text + "','" + tb_artist_curatorId.Text + "','" + tb_artist_fname.Text + "','" + tb_artist_lname.Text + "')";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: " + exception.Message);
                }
                finally
                {
                    con.Close();
                    DisplayTable();
                }
            }
*/




            if (String.IsNullOrEmpty(tb_artist_artistId.Text) || String.IsNullOrEmpty(tb_artist_curatorId.Text) || String.IsNullOrEmpty(tb_artist_fname.Text) || String.IsNullOrEmpty(tb_artist_lname.Text) || tb_artist_artistId.Text.Length != 5 || tb_artist_curatorId.Text.Length != 5 || (tb_artist_fname.Text.Length + tb_artist_lname.Text.Length) > 40)
            {
                MessageBox.Show("Error:fields cannot be empty and artistID and curatorID must be 5 digit!, and first name last name total cannot be more than 40 chars!");
            }
            else
            {
                try
                {
                    con.Open();

                    //way1
                    SqlCommand cmd = new SqlCommand("sp_insert_artist", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //way2
                    //SqlCommand cmd = con.CreateCommand();
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.CommandText = "sp_insert_artist";


                    cmd.Parameters.AddWithValue("artistID", SqlDbType.NVarChar).Value = tb_artist_artistId.Text;//artistID is the @parameter name of stored procedure, and is not case sensitive

                    cmd.Parameters.AddWithValue("CuratorID", SqlDbType.NVarChar).Value = tb_artist_curatorId.Text;

                    cmd.Parameters.AddWithValue("firstName", SqlDbType.NVarChar).Value = tb_artist_fname.Text;

                    cmd.Parameters.AddWithValue("lastName", SqlDbType.NVarChar).Value = tb_artist_lname.Text;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Artist has been added successfully!");
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

        private void bn_viewArtists_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
