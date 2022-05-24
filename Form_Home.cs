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
using static OpenRS.CMessages;

namespace OpenRS
{
    public partial class Form_Home : Form
    {
        string path = "DB_OpenRS1.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\DB_OpenRS1.db";

        SQLiteDataReader dr;

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


        private void Form_Home_Load(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT count(IsTooLate) FROM T1R_OpenRS1 WHERE IsTooLate = 1;";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            dr.Close();
            iMessages = Convert.ToInt32(cmd.ExecuteScalar());

            if (iMessages > 0)
            {
                newMessages = true;
            }
            else if (iMessages == 0)
            {
                newMessages = false;
            }

            if(newMessages == false)
            {
                txt_StatusColor.Text = "•";
                txt_StatusColor.ForeColor = Color.FromArgb(43, 190, 107);
                txt_Messages.Text = "Er zijn geen meldingen.";
            }
            else if(newMessages == true)
            {
                txt_StatusColor.Text = "•";
                txt_StatusColor.ForeColor = Color.FromArgb(255, 70, 70);

                if(iMessages == 1)
                {
                    txt_StatusColor.ForeColor = Color.FromArgb(255, 171, 66);
                    txt_Messages.Text = "Er is 1 melding.";
                }
                else
                {
                    txt_Messages.Text = "Er zijn " + iMessages + " meldingen.";
                }
            }
        }
    }
}
