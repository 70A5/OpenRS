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
    internal class CDBCon
    {
        string path = "DB_OpenRS1.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\DB_OpenRS1.db";

        SQLiteDataReader dr;
        
    }
}
