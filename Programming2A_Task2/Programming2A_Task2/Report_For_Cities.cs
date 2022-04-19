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
    public partial class Report_For_Cities : Form
    {
        public Report_For_Cities()
        {
            InitializeComponent();
        }
        string filepath = @"D:\School Things\Programming 2A\Programming2A_Task2\Programming2A_Task2\Captured_Data.txt";

        private void Report_For_Cities_Load(object sender, EventArgs e)
        {
            string[] data = File.ReadAllLines(filepath);


            for (int i = 0; i < data.Length; i++)
            {

                lsbCities.Items.Add(data[i].ToString().Split('\t')[1]);


            }

        }
        string data = "";
        string heading = " ";
        string End = " ";
        private void btnSave_Click(object sender, EventArgs e)
        {

            StreamReader task = new StreamReader(filepath);

            string line = task.ReadLine();



            heading = "*******************************************************************************************************************\n" +
                    "******************************************Report For Speciefied cities****************************************\n \n";

            End =
                  "\n\n**********************************************End of report*****************************************\n" +
                  "********************************************************************************************************************\n \n";

            while (line != null)
            {
                string myValue = line.Substring(0, line.Length);
                string[] infor = myValue.Split('\t');


                foreach (var city in lsbCities.SelectedItems)
                {
                    if (city.ToString().Equals(infor[1]))
                    {
                        data += "City:" + "\t\t\t" + infor[1] + "\n" + "Minimum Temperature" + "\t" + infor[2] + "\n " + "Maximum Temperature:" + "\t" + infor[3] + "\n" + "Precipitation" + "\t\t" + infor[4] + "\n Humidity:" + "\t\t\t" + infor[5] + "\n" + "Wind Speed" + "\t\t" + infor[6] + " \n" + "Date:" + "\t\t\t" + infor[7]+
                            "\n********************************************************************************************************************";

                    }
                }
                line = task.ReadLine();

            }
            MessageBox.Show("Succesfully Specified", "Favourite");
            task.Close();
        }
    

        private void lsbCities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //stay
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            rtbFinalREport.Text = heading + " " + data + " " + End;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbFinalREport.Clear();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                new frmLogIn().ShowDialog();

            }
            else
            {
                //stay
            }
        }

        string dataInfor = " ";
        
        private void btndisplay_Click(object sender, EventArgs e)
        {

           string heading = 
                
                   "********************************************************************************************************************\n" +
                    "****************************Report For Speciefied cities Search by Date Range******************************\n \n";

           string End =
                  "\n\n***************************************************End of report****************************************\n" +
                  "********************************************************************************************************************\n \n";

            string[] dataholder = File.ReadAllLines(filepath);


            string startDate = dtpStartDate.Value.ToShortDateString();
            string EndDate = dtpEndDate.Value.ToShortDateString();
            StringBuilder task1 = new StringBuilder();

            task1.Append("ID_No:" + "\t " + " City:" + "\t              " + "Min:" + "         " + "Max:" + "      " + "Preci:" + "     " + "Humidity:" + "    " + "WindSpeed" + "             " + "Date");


            if (dataholder != null)
            {
                for (int i = 0; i < dataholder.Length; i++)
                {
                    if (Convert.ToDateTime(dataholder[i].Split('\t')[7]) >= Convert.ToDateTime(startDate) &&
                        Convert.ToDateTime(dataholder[i].Split('\t')[7]) <= Convert.ToDateTime(EndDate))
                    {

                        dataInfor+=dataholder[i];
                    }
                }
            }
            rtbFinalREport.Text = heading + " " +task1+" \n\n"+ dataInfor + " " + End;
        }
    }
}
