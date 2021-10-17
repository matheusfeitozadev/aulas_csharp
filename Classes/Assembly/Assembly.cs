using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao.Classes.Assembly
{
    public class Assembly : ClassBase
    {
        public string AssemblyName { get; set; }
        public Factory Factory { get; set; }
        public Customer Customer { get; set; }
        public List<Property> Properties { get; set; }
    }

    //Herança e Interfaces
}
