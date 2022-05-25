using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRS
{
    public class CMessages
    {
        public static DateTime getCurrentDate = DateTime.Today;
        
        public static bool newMessages;
        public static int iMessages;
        public static int CurrentDate = int.Parse(getCurrentDate.ToString("yyyyMMdd"));
    }
}


