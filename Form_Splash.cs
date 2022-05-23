using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenRS
{
    public partial class Form_Splash : Form
    {
        public Form_Splash()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
        }

        public int progressValue = 0;

        void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (progressValue < 100)
            {
                Random random = new Random();
                int iRnd = random.Next(0, 15);
                progressValue += iRnd;
                if (progressValue > 100)
                {
                    progressValue = 100;
                }
                else
                {
                    progressBar1.Value = progressValue;
                }
                    
            }
            else
            {
                timer1.Stop();
                var FormHome = new Form_Home();
                FormHome.Show();
                this.Hide();
            }
        }
    }
}
