using LogicaProgramacao.Classes.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Classes.Assembly
{
    public class AssemblyPropertyViewModel : ClassBase
    {
        public PropertyViewModel Property { get; set; }
        public int FK_Assembly { get; set; }
        public int FK_Property { get; set; }
        public string PropertyValue { get; set; }
    }
}
