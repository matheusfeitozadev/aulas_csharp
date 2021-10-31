﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao.Classes.Assembly
{
    public class AssemblyViewModel : ClassBase
    {
        public string AssemblyName { get; set; }
        public FactoryViewModel Factory { get; set; }
        public CustomerViewModel Customer { get; set; }
        public List<PropertyViewModel> Properties { get; set; }

        public AssemblyViewModel()
        {

        }

        public AssemblyViewModel(string assemblyName)
        {
            AssemblyName = assemblyName;
        }
    }

    //Herança e Interfaces
}
