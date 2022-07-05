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
    public partial class Form_NewRes : Form
    {
        string path = "DB_OpenRS1.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\DB_OpenRS1.db";

        SQLiteDataReader dr;

        public Form_NewRes()
        {
            InitializeComponent();
            //Fullscreen_Load();
            btn_Foto.Visible = true;
            btn_Video.Visible = true;
            lbl_Video.Visible = false;
            lbl_Foto.Visible = false;
            txt_UID.Visible = false;
            btn_NextStepPhoto.Visible = false;
            lbl_UID.Visible = false;
            lbl_CamSelect.Visible = false;
            btn_OverviewPhoto.Visible = false;

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

        private void btn_Foto_Click(object sender, EventArgs e)
        {
            btn_Foto.Visible = false;
            btn_Video.Visible = false;
            lbl_Video.Visible = false;
            lbl_Foto.Visible = true;
            txt_UID.Visible = true;
            btn_NextStepPhoto.Visible = true;
            lbl_UID.Visible = true;
            lbl_CamSelect.Visible = true;
            btn_OverviewPhoto.Visible = true;

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            string NextOrderIdStm = "SELECT max(Orders) FROM T1R_OpenRS1;";
            var NextOrderIdCmd = new SQLiteCommand(NextOrderIdStm, con);
            dr = NextOrderIdCmd.ExecuteReader();
            dr.Close();
            int NextOrderId = Convert.ToInt32(NextOrderIdCmd.ExecuteScalar()) + 1;
            dr.Close();

            string NextAvailablePhotoStm = "SELECT Cid FROM T2C_OpenRS1 WHERE IsAvailable = 1;";
            var NextAvailablePhotoCmd = new SQLiteCommand(NextAvailablePhotoStm, con);
            dr = NextAvailablePhotoCmd.ExecuteReader();
            dr.Close();
            String NextAvailablePhoto = Convert.ToString(NextAvailablePhotoCmd.ExecuteScalar());
            dr.Close();

            if (NextAvailablePhoto != "")
            {
                lbl_CamSelect.Text = "Camera " + NextAvailablePhoto + " is beschikbaar, en is automatisch geselecteerd.";
                btn_NextStepPhoto.Enabled = true;
            }
            else
            {
                lbl_CamSelect.Text = "Er is momenteel geen fotocamera beschikbaar.";
                btn_NextStepPhoto.Enabled = false;
                btn_NextStepPhoto.Visible = false;
                lbl_UID.Visible = false;
                txt_UID.Visible = false;
            }
        }
        private void btn_NextStepPhoto_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            string NextOrderIdStm = "SELECT max(Orders) FROM T1R_OpenRS1;";
            var NextOrderIdCmd = new SQLiteCommand(NextOrderIdStm, con);
            dr = NextOrderIdCmd.ExecuteReader();
            dr.Close();
            int NextOrderId = Convert.ToInt32(NextOrderIdCmd.ExecuteScalar()) + 1;
            dr.Close();

            string NextAvailablePhotoStm = "SELECT Cid FROM T2C_OpenRS1 WHERE IsAvailable = 1;";
            var NextAvailablePhotoCmd = new SQLiteCommand(NextAvailablePhotoStm, con);
            dr = NextAvailablePhotoCmd.ExecuteReader();
            dr.Close();
            String NextAvailablePhoto = Convert.ToString(NextAvailablePhotoCmd.ExecuteScalar());
            dr.Close();

            string InsertNewPhotoStm = "INSERT INTO T1R_OpenRS1 (Orders, UID, Cid, StartDate, EndDate, IsFinished, IsTooLate) VALUES(@Orders,@UID,@Cid,@StartDate,@EndDate,@IsFinished,@IsTooLate);";
            var InsertNewPhotoCmd = new SQLiteCommand(InsertNewPhotoStm, con);
            string ORDERS = NextOrderId.ToString();
            string UID = txt_UID.Text.ToString();
            string CID = NextAvailablePhoto;
            int STARTDATE = int.Parse(DateTime.Now.ToString("dmmyyyy"));
            int ENDDATE = 0;
            int ISFINISHED = 0;
            int ISTOOLATE = 0;

            InsertNewPhotoCmd.Parameters.AddWithValue("@Orders", ORDERS);
            InsertNewPhotoCmd.Parameters.AddWithValue("@UID", UID);
            InsertNewPhotoCmd.Parameters.AddWithValue("@Cid", CID);
            InsertNewPhotoCmd.Parameters.AddWithValue("@StartDate", STARTDATE);
            InsertNewPhotoCmd.Parameters.AddWithValue("@EndDate", ENDDATE);
            InsertNewPhotoCmd.Parameters.AddWithValue("@IsFinished", ISFINISHED);
            InsertNewPhotoCmd.Parameters.AddWithValue("@IsTooLate", ISTOOLATE);

            InsertNewPhotoCmd.ExecuteNonQuery();

            string UpdatePhotoAvailableStm = "UPDATE T2C_OpenRS1 SET IsAvailable = 0 WHERE Cid = @NextAvailablePhoto;";
            var UpdatePhotoAvailableCmd = new SQLiteCommand(UpdatePhotoAvailableStm, con);

            UpdatePhotoAvailableCmd.Parameters.AddWithValue("@NextAvailablePhoto", NextAvailablePhoto);

            UpdatePhotoAvailableCmd.ExecuteNonQuery();

            //NextOrderId.ToString();
        }
    }
}
