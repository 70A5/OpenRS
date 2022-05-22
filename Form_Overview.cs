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

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Form_Overview()
        {
            InitializeComponent();
            Fullscreen_Load();
            Create_db();
            LoadData();
        }

        private void LoadData()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM T1OpenRS1";
            var cmd =new SQLiteCommand(stm,con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0,dr.GetString(0),dr.GetString(1), dr.GetString(2), dr.GetString(3));
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
                    string sql = "CREATE TABLE T1OpenRS1 (Orders TEXT, Connectie TEXT, Items TEXT, Datum TEXT);";
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
                cmd.CommandText = "INSERT INTO T1OpenRS1 (Orders, Connectie, Items, Datum) VALUES(@Orders,@Connectie,@Items,@Datum);";

                string ORDERS = txt_Orders.Text;
                string CONNECTIE = txt_Connectie.Text;
                string ITEMS = txt_Items.Text;
                string DATUM = txt_Datum.Text;

                cmd.Parameters.AddWithValue("@Orders", ORDERS);
                cmd.Parameters.AddWithValue("@Connectie", CONNECTIE);
                cmd.Parameters.AddWithValue("@Items", ITEMS);
                cmd.Parameters.AddWithValue("@Datum", DATUM);

                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "Order";
                dataGridView1.Columns[1].Name = "Connectie";
                dataGridView1.Columns[2].Name = "Items";
                dataGridView1.Columns[3].Name = "Datum";
                string[] row = new string[] { ORDERS, CONNECTIE, ITEMS, DATUM, };
                dataGridView1.Rows.Add(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            cmd.ExecuteNonQuery();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "UPDATE T1OpenRS1 Set Connectie=@Connectie, Items=@Items, Datum=@Datum WHERE Orders=@Orders;";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Orders", txt_Orders.Text);
            cmd.Parameters.AddWithValue("@Connectie", txt_Connectie.Text);
            cmd.Parameters.AddWithValue("@Items", txt_Items.Text);
            cmd.Parameters.AddWithValue("@Datum", txt_Datum.Text);

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
                cmd.CommandText = "DELETE FROM T1OpenRS1 WHERE Orders =@Orders";
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
                    txt_Connectie.Text = dataGridView1.Rows[e.RowIndex].Cells["Connectie"].FormattedValue.ToString();
                    txt_Items.Text = dataGridView1.Rows[e.RowIndex].Cells["Items"].FormattedValue.ToString();
                    txt_Datum.Text = dataGridView1.Rows[e.RowIndex].Cells["Datum"].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
