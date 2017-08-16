using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Ping_Click(object sender, EventArgs e)
        {


            var pingstatus = IPStatus.DestinationHostUnreachable;

            try
            {
                PingReply pingReply;
                using (var ping = new Ping())
                    pingReply = ping.Send(TB_Ping.Text);
                pingstatus = pingReply.Status;
            }
            catch (Exception exc)
            {

                LB_Message.Text = "Ping er ikke godkendt!! :'-( " + exc.Message;
            }
            if (pingstatus == IPStatus.Success)
            {
                LB_Message.Text = "Ping request på: "+TB_Ping.Text +". er godkendt :-D ";
            }
            else
            {
                LB_Message.Text = "Ping request på: " + TB_Ping.Text + ". er ikke godkendt!! :'-( ";
            }



        }
    }
}
