using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao.Classes.Assembly
{
    public class Boxe
    {
        public string BoxName { get; set; }
        public int Status { get; set; }

        public Boxe(string boxName, int status)
        {
            BoxName = boxName;
            Status = status;
        }
    }
}
