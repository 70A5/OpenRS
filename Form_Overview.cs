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
        }

        private void LoadData()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM Order";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Overview_Load(object sender, EventArgs e)
        {
            
        }
    }
}
