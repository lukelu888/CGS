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
    public partial class loginSql : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LUKE-HP14;Initial Catalog=CGS;Integrated Security=True");

        public loginSql()
        {
            InitializeComponent();
        }

        private void bn_login_login_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = "Select * from login where username = '" + tb_username.Text + "' and password = '" + tb_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);//automatically open connection
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    CuratorSql cf = new CuratorSql();
                    cf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid entry");
                    tb_password.Clear();
                    tb_username.Clear();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
           
        }

        private void bn_login_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
