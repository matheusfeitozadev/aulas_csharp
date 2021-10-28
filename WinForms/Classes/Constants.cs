using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Classes
{
    public class Constants
    {
        public static string AssemblyConn = ConfigurationManager.ConnectionStrings["AssemblyConn"].ToString();
    }
}
