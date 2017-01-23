using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace GrabcioChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 2*60*1000;
            timer.Start();
            Checker.Check(this.info);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Checker.Check(this.info))
            {
                timer.Stop();
                MessageBox.Show("SA OCENY!");
            }
        }
        Timer timer;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }   
    }
}
