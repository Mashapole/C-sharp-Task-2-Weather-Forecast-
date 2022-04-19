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
    public partial class btnClearData : Form
    {
        public btnClearData()
        {
            InitializeComponent();
        }
        private void ViewingAndEditing_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < Capturing.count; i++)
            {
                cmbCities.Items.Add(i);
            }
        }

        string filepath = @"D:\School Things\Programming 2A\Programming2A_Task2\Programming2A_Task2\Captured_Data.txt";
        private void btnView_Click(object sender, EventArgs e)
        {


            StreamReader task = new StreamReader(filepath);

            StringBuilder task1 = new StringBuilder();
             
            task1.Append("Count:"+"\t "+" City:"+"\t"+"Min:"+"         "+ "Max:"+"      "+ "Preci:"+"     "+"Humidity:"+"    "+"WindSpeed" +"   "+ "Date"  );
            string data = " ";


            data += task.ReadToEnd();
            rtf_Report.Text =task1+" \n \n "+ data;


            task.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            rtf_Report.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StreamReader task = new StreamReader(filepath);

            string position = cmbCities.SelectedItem.ToString();


            int myLength;
            string city;
            string[] details;

            string AllLine = task.ReadLine();

            while (AllLine != null)
            {
                myLength = AllLine.Length;
                city = AllLine.Substring(0, myLength);
                details = city.Split('\t');


                if (position == details[0])
                {
                    ClearData(details);

                }
                AllLine = task.ReadLine();
            }


            task.Close();
        }

        public void ClearData(string[] details)
        {
            txtCity.Text = details[1];
            txtMin.Text = details[2];
            txtMax.Text = details[3];
            txtPrecipitation.Text = details[4];
            txtHumidity.Text = details[5];
            txtWind.Text = details[6];
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {

            string updatedCity =cmbCities.Text.ToString()+"\t"+
                txtCity.Text.ToString()+" "+
                Convert.ToInt32(txtMin.Text.ToString()) + " \t" +
                Convert.ToInt32(txtMax.Text.ToString()) + " \t" +
                Convert.ToInt32(txtPrecipitation.Text.ToString()) + " \t" +
                Convert.ToInt32(txtHumidity.Text.ToString()) + "\t" +
                Convert.ToInt32(txtWind.Text.ToString())+"\t"+
                dtpDate.Value.ToShortDateString();

            string positionIndex = cmbCities.SelectedItem.ToString();

            string[] AllLine = File.ReadAllLines(filepath);



            string[] details;
            details = AllLine;

            if (positionIndex == details[int.Parse(positionIndex) - 1].Split('\t')[0])
            {
                string alldata = File.ReadAllText(filepath);
                if (alldata.Contains(details[int.Parse(positionIndex)-1]))
                {
                    alldata = alldata.Replace(details[int.Parse(positionIndex) - 1], updatedCity);
                    File.WriteAllText(filepath, alldata);
                    MessageBox.Show("Data is being edited", "Warning");
                }
            }
        }

        private void btnViewEdited_Click(object sender, EventArgs e)
        {
            txtCity.Clear();
            txtMin.Clear();
            txtMax.Clear();
            txtPrecipitation.Clear();
            txtHumidity.Clear();
            txtWind.Clear();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to log out?","Warning",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Hide();
                new frmLogIn().ShowDialog();

            }
            else 
            {
            //stay
            }
        }
    }
}
