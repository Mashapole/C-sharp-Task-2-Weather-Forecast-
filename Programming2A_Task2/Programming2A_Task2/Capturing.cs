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
    public partial class Capturing : Form
    {
        public Capturing()
        {
            InitializeComponent();
        }

        //this is a variable that is going to store my file path
        string filepath = @"D:\School Things\Programming 2A\Programming2A_Task2\Programming2A_Task2\Captured_Data.txt";
        //this is going to store the number of rows starting from 1
        public static int count = 1;
   

        //this button is capturing all required data
        private void btnCapture_Click(object sender, EventArgs e)
        {
            //this constructor is getting the entry from the admin
            TextWriter Task = new StreamWriter(filepath, true);

            //this is writing every data to file
            Task.WriteLine(count.ToString()+"\t" +
                txtCity.Text.ToString()+"\t" +
                Convert.ToInt32(txtMin.Text.ToString()) + " \t" +
                Convert.ToInt32(txtMax.Text.ToString()) + " \t" +
                Convert.ToInt32(txtPrecipitation.Text.ToString()) + " \t" +
                Convert.ToInt32(txtHumidity.Text.ToString()) + "\t" +
                Convert.ToInt32(txtWind.Text.ToString())+"\t"+
                dTPCapture.Value.ToShortDateString());


            MessageBox.Show("Data is stored", "Succesfully Stored");

            //this is increasing the size of count
            count++;
            //this is clearing city field
            txtCity.Clear();
            //this is clearing minimum field
            txtMin.Clear();
            //this is clearing Maximum field
            txtMax.Clear();
            //this is clearing precipitation field
            txtPrecipitation.Clear();
            //this is clearing wind speed field
            txtWind.Clear();
            //this is clearing Humidity field
            txtHumidity.Clear();

            //this method is flusing the file
            Task.Flush();
            //this method is closing the file
            Task.Close();
        }

        //this button is calling another form
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new btnClearData().ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Capturing_Load(object sender, EventArgs e)
        {
            File.WriteAllText(filepath,"");
        }
    }
}
