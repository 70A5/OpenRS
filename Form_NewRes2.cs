using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OpenRS.CDBCon;

namespace OpenRS
{
    public partial class Form_NewRes2 : Form
    {
        public Form_NewRes2()
        {
            InitializeComponent();

            DataSet ds = new DataSet();

            lvi_leerling.BeginUpdate();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = row["ID"].ToString();
                lvi.SubItems.Add(row["Name"].ToString());
                lvi.SubItems.Add(row["Score"].ToString());
                lvi_leerling.Items.Add(lvi);
            }
            this.lvi_leerling.EndUpdate();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {

        }
    }
}
