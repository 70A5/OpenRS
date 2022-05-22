using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace OpenRS
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
            //Fullscreen_Load();
        }

        private void Fullscreen_Load()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_NewRes_Click(object sender, EventArgs e)
        {
            var FormNewRes = new Form_NewRes();
            FormNewRes.Show();
            this.Hide();

        }

        private void Btn_IntakeRes_Click(object sender, EventArgs e)
        {
            var FormIntakeRes = new Form_IntakeRes();
            FormIntakeRes.Show();
            this.Hide();

        }

        private void Btn_EditRes_Click(object sender, EventArgs e)
        {
            var FormEditRes = new Form_EditRes();
            FormEditRes.Show();
            this.Hide();

        }

        private void Btn_Overview_Click(object sender, EventArgs e)
        {
            var FormOverview = new Form_Overview();
            FormOverview.Show();
            this.Hide();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
