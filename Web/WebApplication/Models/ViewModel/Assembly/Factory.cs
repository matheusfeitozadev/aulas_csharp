using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Models.DB;
using WinForms.Classes.Entity;

namespace LogicaProgramacao.Classes.Assembly
{
    public class FactoryViewModel : ClassBase
    {
        public string Name { get; set; }

        public FactoryViewModel()
        {

        }

        public FactoryViewModel(int id)
        {
            Id = id;
        }

        public static FactoryViewModel ReturnClassBase(Factory factory)
        {
            var model = new FactoryViewModel();
            model.Id = factory.Id;
            model.Name = factory.Name;
            model.Active = factory.Active;

            return model;
        }
    }
}
