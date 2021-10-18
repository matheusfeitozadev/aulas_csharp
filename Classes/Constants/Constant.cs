using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao.Classes.Constants
{
    public class Constant
    {
        public static string Customer = ConfigurationManager.AppSettings["Customer"];
        public static string Division = ConfigurationManager.AppSettings["Division"];
        public static string Equipment = ConfigurationManager.AppSettings["Equipment"];
        public static string Test = ConfigurationManager.AppSettings["Test"];
    }
}
