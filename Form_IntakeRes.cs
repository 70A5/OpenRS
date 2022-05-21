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
    public partial class Form_IntakeRes : Form
    {
        public Form_IntakeRes()
        {
            InitializeComponent();
            Fullscreen_Load();
        }

        private void Fullscreen_Load()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            var FormHome = new Form_Home();
            FormHome.Show();
            this.Close();
        }
    }
}
