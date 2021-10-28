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
        public CustomerViewModel Customer { get; set; }
        public List<Property> Properties { get; set; }

        public Assembly()
        {

        }

        public Assembly(string assemblyName)
        {
            AssemblyName = assemblyName;
        }

        public void Add(Assembly model)
        {

        }

        public void Update()
        {

        }
    }

    //Herança e Interfaces
}
