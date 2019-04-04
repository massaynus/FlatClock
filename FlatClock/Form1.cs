using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Clock.Value < 59)
            {
                Clock.PerformStep();
            }
            else Clock.Value = 1;

            Clock.SuperscriptText = Clock.Value.ToString("00");
            Clock.Text = DateTime.Now.ToShortTimeString();
        }

        private void Clock_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clock.Value = DateTime.Now.Second;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
