using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMXColors
{
    public partial class ShowItem : UserControl
    {
        public Random random = new Random();
        public Color ThisColor { get; set; }
        public int ID { get; set; }
        public int TimeElapsed { get; set; }
        public ShowItem()
        {
            InitializeComponent();
            lblID.Text = ID.ToString();
            ThisColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            pnlItemColor.BackColor = ThisColor;
            
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            cdlColor.AllowFullOpen = true;
            cdlColor.FullOpen = true;
            cdlColor.ShowDialog();
            pnlItemColor.BackColor = cdlColor.Color;
            ThisColor = cdlColor.Color;
        }

        public void tmr_Tick(object sender, EventArgs e)
        {

        }


    }
}
