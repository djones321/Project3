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


        WeatherList wd = new WeatherList();
        Stack<WeatherList> ws = new Stack<WeatherList>();

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
                        wd = new WeatherList();
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
                    for (int i = 0; i < wd.Count; i++)
                    {
                        uxDatesList.DataSource = wd[i].ToString();
                    }

                }catch(Exception ex)
                {
                    MessageBox.Show("Something Went Wrong\n" + ex.ToString());

                }
            }
        }

        private void uxFilterButton_Click(object sender, EventArgs e)
        {
            if (uxAboveTemp.Checked)
            {
                WeatherList temp = new WeatherList(wd);
                ws.Push(temp);
                wd.FilterTemp(Convert.ToDouble(uxTempSetting.ToString()), 1);
            }
            else if (uxBelowTemp.Checked)
            {
                WeatherList temp = new WeatherList(wd);
                ws.Push(temp);
                wd.FilterTemp(Convert.ToDouble(uxTempSetting.ToString()), 0);
            }
            else if (uxDateRange.Checked)
            {
                try
                {
                    WeatherList temp = new WeatherList(wd);
                    ws.Push(temp);
                    wd.FilterRange(uxCalendar.SelectionRange.Start, uxCalendar.SelectionRange.End);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Must select dates\n" + ex.ToString());
                }
            }
            else if (uxThisDate.Checked)
            {
                try
                {
                    WeatherList temp = new WeatherList(wd);
                    ws.Push(temp);
                    wd.FilterDateHistory(uxCalendar.SelectionRange.Start);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Must select a date\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a filter");
            }
        }

        private void uxUndoButton_Click(object sender, EventArgs e)
        {
            wd = new WeatherList(ws.Pop());
        }
    }
}
