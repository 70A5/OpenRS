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
    public partial class Form_IntakeRes : Form
    {
        public Form_IntakeRes()
        {
            

            SQLiteDataReader dr;

            InitializeComponent();
            //Fullscreen_Load();
        }

        private void Fullscreen_Load()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            var FormHome = new Form_Home();
            FormHome.Show();
            this.Close();
        }

        private void btn_IntakeComplete_Click(object sender, EventArgs e)
        {
            string path = "DB_OpenRS1.db";
            string cs = @"URI=file:" + Application.StartupPath + "\\DB_OpenRS1.db";

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            string UpdatePhotoAvailableStm = "UPDATE T2C_OpenRS1 SET IsAvailable = 1 WHERE Cid = @OrderID;";
            var UpdatePhotoAvailableCmd = new SQLiteCommand(UpdatePhotoAvailableStm, con);

            UpdatePhotoAvailableCmd.Parameters.AddWithValue("@OrderID", txt_IntakeComplete.Text);

            UpdatePhotoAvailableCmd.ExecuteNonQuery();

            MessageBox.Show("Camera " + txt_IntakeComplete.Text + " is gemarkeerd als beschikbaar.");

            var FormHome = new Form_Home();
            FormHome.Show();
            this.Close();
        }
    }
}
