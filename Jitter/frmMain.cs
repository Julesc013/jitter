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

namespace Jitter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            try
            {

                // Initialise a new ping object.
                Ping ping = new Ping();
                PingReply reply;
                string input;
                input = txtIP.Text;
                reply = ping.Send(input);

                if (reply.Status == IPStatus.Success) // If the ping was successful.
                {
                    // Add reply data to the table.
                    dataGridView.Rows.Add(input.ToString(), reply.Address.ToString(), reply.RoundtripTime.ToString());
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

        }

    }
}
