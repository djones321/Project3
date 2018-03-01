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

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<WeatherData> wd = new List<WeatherData>();

        private void uxOpenMenu_Click(object sender, EventArgs e)   //More error checking here if time
        {
            
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (uxDatesList.Items.Count > 0)
                    {
                        uxDatesList.DataSource = null;
                        uxDatesList.Items.Clear();
                        wd = new List<WeatherData>();
                    }

                    string name = uxOpenFileDialog.FileName;
                    using (StreamReader inFile = new StreamReader(name))
                    {
                        string line;
                        char[] sep = new char[] { ' ' };
                        while ((line = inFile.ReadLine()) != null)
                        {
                            string[] data = new string[4];
                            data = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                            if (Convert.ToDouble(data[3]) != -99)
                            {
                                wd.Add(new WeatherData(Convert.ToInt32(data[0]),
                                    Convert.ToInt32(data[1]), Convert.ToInt32(data[2]),
                                    Convert.ToDouble(data[3])));
                            }
                        }
                    }
                    uxDatesList.DataSource = wd;


                }catch(Exception ex)
                {
                    MessageBox.Show("Something Went Wrong\n" + ex.ToString());

                }
            }
        }





    }
}
