using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Timers;

namespace Jitter
{
    public partial class frmMain : Form
    {

        bool run; // Only run loop when this is true.

        public frmMain()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {

            int iterations = Convert.ToInt32(numIterations.Value);
            int interval = Convert.ToInt32(numInterval.Value); // Get the desired wait interval.

            // Enable stop button if the task will take a long time.
            if (iterations >= 20 || interval >= 20 || iterations * interval >= 20)
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                btnStop.Visible = true;
                btnStart.Visible = false;
            }

            // Initialise a new ping object.
            Ping ping = new Ping();
            PingReply reply;
            // Get address to ping.
            string inputRaw = txtIP.Text;
            string[] inputArray = inputRaw.Split(Convert.ToChar("/"));
            string input = inputArray[0];

            try
            {

                run = true; // Enable loop.

                while (iterations != 0 && run == true) // Ping for the number of iterations specified.
                {

                    reply = ping.Send(input);

                    if (reply.Status == IPStatus.Success) // If the ping was successful.
                    {

                        // Get response values.
                        string address = reply.Address.ToString();
                        string responseTime = reply.RoundtripTime.ToString();

                        // Add reply data to the table and chart.
                        dataGridView.Rows.Add(input, address, responseTime);
                        chartResponseTimes.Series["Response Times"].Points.AddY(responseTime);

                        // Scroll to latest row.
                        try
                        {
                            dataGridView.FirstDisplayedScrollingRowIndex += 1;
                        }
                        catch { }
                    }

                    // Get average response time and other statistical values.
                    int[] responseTimes = (from DataGridViewRow row in dataGridView.Rows
                                        where row.Cells[2].FormattedValue.ToString() != string.Empty
                                        select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();
                    int responseTimesLength = responseTimes.Length;

                    // Declare values for statistics and set them.
                    int pingMinimum = responseTimes.Min();
                    int pingMaximum = responseTimes.Max();
                    int pingAverage = Convert.ToInt32(responseTimes.Average());
                    int pingChange = 0;
                    int jitter = 0;

                    try
                    {

                        //Calculate jitter.
                        for (int i = 1; i < responseTimesLength; i++)
                        {
                            // Get the total change (in ms) between each ping)
                            pingChange += Math.Abs(responseTimes[i] - responseTimes[i - 1]);
                        }

                        jitter = pingChange / (responseTimesLength - 1); //Divide the total change by the number of changes.

                    }
                    catch (DivideByZeroException) { }

                    // Populate text boxes.
                    lblMinimum.Text = "Minimum: " + pingMinimum.ToString() + " ms"; // Min Value.
                    lblMaximum.Text = "Maximum: " + pingMaximum.ToString() + " ms"; // Max Value.
                    lblAverage.Text = "Average: " + pingAverage.ToString() + " ms"; // Average Value.
                    lblJitter.Text = "Jitter: " + jitter.ToString() + " Δms"; // Jitter Value.


                    await Task.Delay(interval); // Wait for the prescribed interval.
                    iterations -= 1; // Decrement iterations to go.

                }
                
            }

            catch (ArgumentNullException)
            {
                MessageBox.Show("Please use valid IP or web address.", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (PingException ex)
            {
                MessageBox.Show(ex.Message, "Ping Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Re-enable buttons.
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnStop.Visible = false;
            btnStart.Visible = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            // Clear existing data in table and chart.
            dataGridView.Rows.Clear();
            chartResponseTimes.Series["Response Times"].Points.Clear();

            // Reset text boxes.
            lblMinimum.Text = "Minimum: N/A"; // Min Value.
            lblMaximum.Text = "Maximum: N/A"; // Max Value.
            lblAverage.Text = "Average: N/A"; // Average Value.
            lblJitter.Text = "Jitter: N/A"; // Jitter Value.

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            // Interrupt loop.
            run = false;

        }
    }
}
