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
    public partial class Registering : Form
    {
        public Registering()
        {
            InitializeComponent();
        }

        private void Registering_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword1.PasswordChar = '*';
        }

        int counter = 2;
        string filepath = @"D:\School Things\Programming 2A\Programming2A_Task2\Programming2A_Task2\Login_Details.txt";
        private void btnRegister_Click(object sender, EventArgs e)
        {
           
                TextWriter task1 = new StreamWriter(filepath, true);

                task1.WriteLine(counter + ":" + txtUsername1.Text.ToString() + ":" + txtPassword1.Text.ToString());
                MessageBox.Show("Registered","Warning");

                counter++;


                  txtUsername1.Clear();
                  txtPassword1.Clear();
                  task1.Close();

        
        }
            
        

        private void btnContinue_Click(object sender, EventArgs e)
        {
                this.Hide();
                new frmLogIn().ShowDialog();
               
        }
    }
}
