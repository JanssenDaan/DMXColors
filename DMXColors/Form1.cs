using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DjanControls;
using Dmx512UsbRs485;

namespace DMXColors
{
    public partial class Form1 : Form
    {
        public static new Form1 Instance { get; set; }
        public Dmx512UsbRs485Driver dmx = new Dmx512UsbRs485Driver();
        public Helpers h = new Helpers();
        public List<ShowItem> UCS = new List<ShowItem>();
        public int ItemNow { get; set; }
        public int ItemTotal { get; set; }
        public int TimePassed { get; set; }
        public int TimeToPass { get; set; }

        public int IDnmbr { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
            Instance = this; 
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dmx.NrOfPorts; i++)
            {
                cbxPort.Items.Add(dmx.PortNameAt(i));
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var UC = new ShowItem();
            UC.ID = IDnmbr;
            UC.lblID.Text = IDnmbr.ToString();
           
            pnlShowItems.Controls.Add(UC);
            IDnmbr++;
        }

        private void btnStartShow_Click(object sender, EventArgs e)
        {
            //UCS = pnlShowItems.Controls.OfType<ShowItem>()
            //                             .Where(r => r.Tag.ToString() == "It's not important")
            //                             .ToList(); ;

            UCS = pnlShowItems.Controls.OfType<ShowItem>().ToList(); ;
           

            WorkList();
        }

        private void WorkList()
        {
            ItemTotal = UCS.Count;
            TimePassed = 0;
            IDnmbr = 0;
            TimeToPass = Convert.ToInt32(UCS[IDnmbr].nudDjan.Value);
            tmrShow.Start();

            //foreach (ShowItem item in UCS)
            //{
            //    item.tmr.Start();
            //    Thread.Sleep(Convert.ToInt32(item.nudDjan.Value * 1000));
            //}
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            try
            {
                pnlShow.BackColor = UCS[IDnmbr].ThisColor;
                PassToLamp(UCS[IDnmbr].ThisColor);
                if (TimePassed >= TimeToPass)
                {
                    TimePassed = 0;
                    IDnmbr++;
                    TimeToPass = Convert.ToInt32(UCS[IDnmbr].nudDjan.Value);
                }
                else
                {
                }
                TimePassed++;
            }
            catch (Exception)
            {
                tmrShow.Stop();

                h.ShowMessage("Show Afgelopen");
            }
           
            //if (ItemNow < ItemTotal)
            //{
            //    tmrShow.Interval = Convert.ToInt32(UCS[ItemNow].nudDjan.Value * 1000);
            //    pnlShow.BackColor = UCS[ItemNow].ThisColor;
            //    ItemNow++;
            //}
            //else
            //{
            //    tmrShow.Stop();
            //}

        }

        private void PassToLamp(Color c)
        {
            dmx.DmxLoadBuffer(1, (byte)c.R, 512);
            dmx.DmxLoadBuffer(2, (byte)c.G, 512);
            dmx.DmxLoadBuffer(3, (byte)c.B, 512);
            dmx.DmxSendCommand(512);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dmx.DmxToDefault(dmx.PortNameAt(0));
            //Color c = Color.Aqua;
            //dmx.DmxLoadBuffer(1, (byte)c.R, 512);
            //dmx.DmxLoadBuffer(2, (byte)c.G, 512);
            //dmx.DmxLoadBuffer(3, (byte)c.B, 512);
            //dmx.DmxSendCommand(512);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string x = h.ToXML(UCS);
        }
    }
}
