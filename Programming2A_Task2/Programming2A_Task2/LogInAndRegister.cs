using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programming2A_Task2
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

       private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar='*';
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
          string username = " ";
          string password = " ";

       
        //this is storing file path
        string filepath = @"D:\School Things\Programming 2A\Programming2A_Task2\Programming2A_Task2\Login_Details.txt";

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            string[] dataholder = File.ReadAllLines(filepath);

            if (dataholder != null)
            {
                ;


                string username = txtUsername.Text;
                string generalPassword = txtPassword.Text;



                for (int i = 0; i < dataholder.Length; i++)
                {
                    if (dataholder[i].Split(':')[1].Equals(txtUsername.Text) && dataholder[i].Split(':')[2].Equals(txtPassword.Text) && dataholder[i].Split(':')[0].Equals("1"))
                    {

                        MessageBox.Show(" " + "Welcome Admin", "Access granted ");

                        this.Hide();
                        new Capturing().ShowDialog();


                    }

                    else if (dataholder[i].Split(':')[1].Equals(txtUsername.Text) && dataholder[i].Split(':')[2].Equals(txtPassword.Text) && !dataholder[i].Split(':')[0].Equals("1"))
                    {
                        MessageBox.Show("General User","Access granted to you");
                        this.Hide();
                        new Report_For_Cities().ShowDialog();

                    }
                }
            }
        }

         private void btnRegister_Click(object sender, EventArgs e)
         {
            this.Hide();
            new Registering().ShowDialog();
         }

        private void lblUsername_Click(object sender, EventArgs e)
        {
         //
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
         //
        }

        private void lblUSer_Click(object sender, EventArgs e)
        {
            //
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                frmLogIn formload = new frmLogIn();
                //formload.sh
                //stay
            }
        }
    }
}
