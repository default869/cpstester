using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpsTestet
{
    public partial class CPSTester : Form
    {
        Timer timer = new Timer();
        int timerCounter = 4; 
        int clicksCount = 0;
        public CPSTester()
        {
            InitializeComponent();
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(timer_Tick); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clicksCount += 1;
            cpsLabel.Text = clicksCount.ToString();
            if (clicksCount == 1) timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (this.label1.Text == "00:00")
            {
                timer.Stop();
                this.label1.Text = "00:05";
                int cps;
                cps = Convert.ToInt32(cpsLabel.Text);
                float res = cps / 5;
                MessageBox.Show(res.ToString() + " Clicks Per Second", "CPS Tester");
                Application.Restart();
            }
            this.label1.Text = "00:0" + (timerCounter--).ToString();
        }
        private void cpsLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
