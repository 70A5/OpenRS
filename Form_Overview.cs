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
    public partial class Form_Overview : Form
    {
        string path = "DB_OpenRS1.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\DB_OpenRS1.db";

        SQLiteDataReader dr;

        public Form_Overview()
        {
            InitializeComponent();
            //Fullscreen_Load();
            Create_db();
            LoadData();
        }

        private void LoadData()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM T1R_OpenRS1";
            var cmd =new SQLiteCommand(stm,con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0,dr.GetString(0),dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4), dr.GetInt32(5));
            }
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite =new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE T1R_OpenRS1 (Orders TEXT, UID TEXT, Cid TEXT, Datum TEXT, IsFinished INTEGER, IsTooLate INTEGER); CREATE TABLE T2C_OpenRS1 (Cid TEXT, Make TEXT, Model TEXT, Serial TEXT, Lens TEXT, IsAvailable INTEGER); CREATE TABLE T3U_OpenRS1 (UID TEXT, Voornaam TEXT, Tussenvoegsel TEXT, Achternaam TEXT, Email TEXT, HasActiveOrder INTEGER);";
                    SQLiteCommand command = new SQLiteCommand(sql,sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Failed to create database. Does it already exist?");
                return;
            }
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

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO T1R_OpenRS1 (Orders, UID, Cid, Datum, IsFinished, IsTooLate) VALUES(@Orders,@UID,@Cid,@Datum,@IsFinished,@IsTooLate);";

                string ORDERS = txt_Orders.Text;
                string UID = txt_UID.Text;
                string CID = txt_Items.Text;
                string DATUM = txt_Datum.Text;
                int ISFINISHED = int.Parse(txt_IsFinished.Text);
                int ISTOOLATE = int.Parse(txt_IsTooLate.Text);

                cmd.Parameters.AddWithValue("@Orders", ORDERS);
                cmd.Parameters.AddWithValue("@UID", UID);
                cmd.Parameters.AddWithValue("@Cid", CID);
                cmd.Parameters.AddWithValue("@Datum", DATUM);
                cmd.Parameters.AddWithValue("@IsFinished", ISFINISHED);
                cmd.Parameters.AddWithValue("@IsTooLate", ISTOOLATE);

                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Order";
                dataGridView1.Columns[1].Name = "UID";
                dataGridView1.Columns[2].Name = "Cid";
                dataGridView1.Columns[3].Name = "Datum";
                dataGridView1.Columns[4].Name = "IsFinished";
                dataGridView1.Columns[5].Name = "IsTooLate";
                string[] row = new string[] { ORDERS, UID, CID, DATUM, ISFINISHED.ToString(), ISTOOLATE.ToString()};
                dataGridView1.Rows.Add(row);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "UPDATE T1R_OpenRS1 Set UID=@UID, Cid=@Cid, Datum=@Datum, IsFinished=@IsFinished, IsTooLate=@IsTooLate WHERE Orders=@Orders;";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Orders", txt_Orders.Text);
            cmd.Parameters.AddWithValue("@UID", txt_UID.Text);
            cmd.Parameters.AddWithValue("@Cid", txt_Items.Text);
            cmd.Parameters.AddWithValue("@Datum", txt_Datum.Text);
            cmd.Parameters.AddWithValue("@IsFinished", txt_IsFinished.Text);
            cmd.Parameters.AddWithValue("@IsTooLate", txt_IsTooLate.Text);

            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "DELETE FROM T1R_OpenRS1 WHERE Orders =@Orders";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Orders", txt_Orders.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                LoadData();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    txt_Orders.Text = dataGridView1.Rows[e.RowIndex].Cells["Order"].FormattedValue.ToString();
                    txt_UID.Text = dataGridView1.Rows[e.RowIndex].Cells["UID"].FormattedValue.ToString();
                    txt_Items.Text = dataGridView1.Rows[e.RowIndex].Cells["Cid"].FormattedValue.ToString();
                    txt_Datum.Text = dataGridView1.Rows[e.RowIndex].Cells["Datum"].FormattedValue.ToString();
                    txt_IsFinished.Text = dataGridView1.Rows[e.RowIndex].Cells["IsFinished"].FormattedValue.ToString();
                    txt_IsTooLate.Text = dataGridView1.Rows[e.RowIndex].Cells["IsTooLate"].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
