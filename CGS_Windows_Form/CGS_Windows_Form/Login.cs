using CGS_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static CGS_Lib.Constants;

namespace CGS_Windows
{
    public partial class Login : Form
    {

        private int counter = 0;
        private string filePath = DIRPATH + "login.txt";
        public Login()
        {
            InitializeComponent();
        }

        //propfull shortcut
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        private void bn_submit_Click(object sender, EventArgs e)
        {
             
            if (String.IsNullOrEmpty(txb_username.Text) || String.IsNullOrEmpty(txb_password.Text))
            {
                MessageBox.Show("username or password cannot be empty");
            }
            else
            {
/*
                // for a pair better use dictionry, if only use two list and Contains(), the key dont necessarily match the value as long as they both in the list
                List<string> userName = new List<string>();
                List<string> passWord = new List<string>();
                //string[] name = new string[10];
                //string[] word = new string[10];
                using (StreamReader sr = new StreamReader(@"C:\Users\luyin\Documents\LCI\fall2022\multitierApplication\lecture\Project1\CGS_Windows_Form\CGS_Windows_Form\login.txt"))
                {
                    while (sr.Peek() != -1)
                    {
                        string str = sr.ReadLine();
                        //name.Append(str.Split(',')[0]); // array append, list add

                        userName.Add(str.Split(',')[0]);
                        passWord.Add(str.Split(',')[1]);

                    }
                }


                if (userName[i] == txb_username.Text && passWord[i] == txb_password.Text)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    //mainForm.Visible = true;
                    //mainForm.Activate();

                }
                else
                {
                    if (counter == 2)
                    {
                        MessageBox.Show("you reach the maximum times of trying password! the application will exit!");
                        this.Close();

                        //Application.Exit();    // better not use, this only kill current form thread, not afftect other thread, so have to kill in task manager, better with the this.Close()  
                    }
                    MessageBox.Show($"Wrong password! {2 - counter} times left to try!");
                    counter++;
                    txb_username.Clear();
                    txb_password.Clear();
                }
            }

            //Dictionary<string, string>  can put outside while loop

*/


            //using (StreamReader sr = new StreamReader(@"C:\Users\luyin\Documents\LCI\fall2022\multitierApplication\lecture\Project1\CGS_Windows_Form\CGS_Windows_Form\login.txt")) //absolute path. @ make it literal(no escape sequence)
            //using (StreamReader sr = new StreamReader("C:\\Users\\luyin\\Documents\\LCI\\fall2022\\multitierApplication\\lecture\\Project1\\CGS_Windows_Form\\CGS_Windows_Form\\login.txt"))// absolute path without @
            using (StreamReader sr = new StreamReader(filePath))
                {
                    while (sr.Peek() != -1)
                    {
                        string str = sr.ReadLine();
                       

                        string userName=str.Split(',')[0];
                        string passWord=str.Split(',')[1];

                        if (userName == txb_username.Text && passWord == txb_password.Text)
                        {
                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.ShowDialog();
                            this.Close();
                            //mainForm.Visible = true;
                            //mainForm.Activate();
                            return;
                        }
                        
                         
                        
                    }
                }

                if (counter == 2)
                {
                    MessageBox.Show("you reach the maximum times of trying password! the application will exit!");
                    this.Close();

                    //Application.Exit();    // better not use, this only kill current form thread, not afftect other thread, so have to kill in task manager, better with the this.Close()  
                }
                MessageBox.Show($"Wrong password! {2 - counter} times left to try!");
                counter++;
                txb_username.Clear();
                txb_password.Clear();



            }

          

        }


        private void bn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bn_login_register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txb_username.Text) || String.IsNullOrEmpty(txb_password.Text))
            {
                MessageBox.Show("username or password cannot be empty");
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        sw.WriteLine(txb_username.Text + "," + txb_password.Text);
                    }
                    MessageBox.Show($"Congrats! your username:{txb_username.Text} and password: {txb_password.Text} is registered!");
                }
                catch (IOException ex)
                {

                    MessageBox.Show(ex.Message);
                }
                txb_password.Clear();
                txb_username.Clear();
               
            }
        }
    }



    
}
