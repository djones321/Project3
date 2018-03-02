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

        /// <summary>
        /// on open menu click, loads file and listbox contents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenMenu_Click(object sender, EventArgs e)   //More error checking here if time
        {
            
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //try
                //{
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

                    uxDatesList.DataSource = wd;

                //}catch(Exception ex)
                //{
                //    MessageBox.Show("Something Went Wrong\n" + ex.ToString());

                //}
            }
        }

        /// <summary>
        /// Button checks radio button and (attempts) to filter listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void uxFilterButton_Click(object sender, EventArgs e)
        {
            if (uxAboveTemp.Checked)
            {
                WeatherList temp = new WeatherList(wd);
                ws.Push(temp);
                wd.FilterTemp(Convert.ToDouble(uxTempSetting.Value), true);
                uxDatesList.DataSource = null;
                uxDatesList.Items.Clear();
                uxDatesList.DataSource = wd;

            }
            else if (uxBelowTemp.Checked)
            {
                WeatherList temp = new WeatherList(wd);
                ws.Push(temp);
                wd.FilterTemp(Convert.ToDouble(uxTempSetting.Value), false);
                uxDatesList.DataSource = null;
                uxDatesList.Items.Clear();
                uxDatesList.DataSource = wd;
            }
            else if (uxDateRange.Checked)
            {
                try
                {
                    WeatherList temp = new WeatherList(wd);
                    ws.Push(temp);
                    wd.FilterRange(uxCalendar.SelectionRange.Start, uxCalendar.SelectionRange.End);
                    uxDatesList.DataSource = null;
                    uxDatesList.Items.Clear();
                    
                    uxDatesList.DataSource = wd;
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
                    uxDatesList.DataSource = null;
                    uxDatesList.Items.Clear();
                    uxDatesList.DataSource = wd;
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

        /// <summary>
        /// should pop previous weatherlists and use those
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void uxUndoButton_Click(object sender, EventArgs e)
        {
            if (ws.Count > 0)
            {
                wd = new WeatherList(ws.Pop());
                uxDatesList.DataSource = null;
                uxDatesList.Items.Clear();
                uxDatesList.DataSource = wd;
            }
            else
                MessageBox.Show("No filters to undo");
        }
    }
}
