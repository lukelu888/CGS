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
using System.Runtime.InteropServices;
using System.Security.Cryptography;


namespace CGS_Windows_Form
{
    public partial class CuratorSql : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LUKE-HP14;Initial Catalog=CGS;Integrated Security=True");
        public CuratorSql()
        {
            InitializeComponent();
        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DisplayTable()
        {
            con.Open();
           
            SqlCommand cmd = con.CreateCommand();// build in method of con object, 
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from curator";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dgv_curator.DataSource = dt;


            con.Close();





        }
        //private void myClearAll(Control.ControlCollection controls) // save as lambda expression
        //{
        //    foreach (Control control in controls)
        //    {
        //        if (control is TextBox)
        //        {
        //            (control as TextBox).Clear();
        //        }
        //    }
        //}

        private void ClearAll()
        {
            Action<Control.ControlCollection> myClearAll = null; // event listener
            
            myClearAll = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                }

            };
            myClearAll(Controls);
        }

        private void bn_addCurator_Click(object sender, EventArgs e)
        {
          /*  con.Open();

            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Curator values ('" + txb_curator_Id.Text + "','" + txb_curator_fname.Text + "','" + txb_curator_lname.Text + "'," + txb_curator_commission.Text + ")";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Curator has been successfully added!");


            }
            catch (Exception exception)
            {

                MessageBox.Show("Error: " + exception.Message);
                //MessageBox.Show("Error: " + e.ToString());
               
            }
            finally
            {
                con.Close();
                DisplayTable();
            }*/


            // since database have check constraint so we dont need check length here
            //if (String.IsNullOrEmpty(txb_curator_Id.Text) || String.IsNullOrEmpty(txb_curator_fname.Text) || String.IsNullOrEmpty(txb_curator_lname.Text) || String.IsNullOrEmpty(txb_curator_commission.Text) || txb_curator_Id.Text.Length != 5  || (txb_curator_fname.Text.Length + txb_curator_lname.Text.Length) > 40)
            if (String.IsNullOrEmpty(txb_curator_Id.Text) || String.IsNullOrEmpty(txb_curator_fname.Text) || String.IsNullOrEmpty(txb_curator_lname.Text) || String.IsNullOrEmpty(txb_curator_commission.Text) || (txb_curator_fname.Text.Length + txb_curator_lname.Text.Length) > 40)
            {
                MessageBox.Show("Error:fields cannot be empty and artistID and curatorID must be 5 digit!, and first name last name total cannot be more than 40 chars!");
            }
            else
            {
                try
                {
                    con.Open();

                    //way1
                    SqlCommand cmd = new SqlCommand("sp_insert_curator", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //way2
                    //SqlCommand cmd = con.CreateCommand();
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.CommandText = "sp_insert_curator";


                    cmd.Parameters.AddWithValue("CuratorID", SqlDbType.NVarChar).Value = txb_curator_Id.Text;

                    cmd.Parameters.AddWithValue("firstName", SqlDbType.NVarChar).Value = txb_curator_fname.Text;

                    cmd.Parameters.AddWithValue("lastName", SqlDbType.NVarChar).Value = txb_curator_lname.Text;

                    cmd.Parameters.AddWithValue("commission", SqlDbType.NVarChar).Value = Convert.ToDouble(txb_curator_commission.Text);                  

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Curator has been added successfully!");
                    ClearAll();
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

        private void RefreshDGV_Curator()
        {

            //dgv_curator


            string query = "SELECT * FROM Curator"; // can change to stored procedure, better
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //DataSet is same as DataTable, but older
            DataSet ds =  new DataSet();
            sda.Fill(ds);
            dgv_curator.DataSource = ds.Tables[0];

        }

        private void RefreshDGV_Artist()
        {
            string query1 = "SELECT * FROM Artist";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            //DataSet is same as DataTable, but older
            DataSet ds1 = new DataSet();


            //sda.Fill(ds1,"Curator"); // this works also
            sda1.Fill(ds1);
            dgv_Artist.DataSource = ds1.Tables[0];
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshDGV_Curator();
            RefreshDGV_Artist();
            timer1.Start(); // this is optional 
        }

        private void CuratorSql_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


    }
}
