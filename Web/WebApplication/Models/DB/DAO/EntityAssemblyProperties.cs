using LogicaProgramacao.Classes.Assembly.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Models.DB;
using WinForms.Classes.Assembly;

namespace WinForms.Classes.Entity
{
    public class EntityAssemblyProperties : GenericInterface<AssemblyPropertyViewModel>
    {
        public int Add(AssemblyPropertyViewModel model)
        {
            var context = new CursoDEVContext();

            AssemblyProperty assemblyProperty = new AssemblyProperty();
            assemblyProperty.FK_Assembly = model.FK_Assembly;
            assemblyProperty.FK_Property = model.FK_Property;
            assemblyProperty.PropertyValue = model.PropertyValue;

            assemblyProperty = context.AssemblyProperties.Add(assemblyProperty);

            context.SaveChanges();

            return assemblyProperty.Id;
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<AssemblyPropertyViewModel> List()
        {
            throw new NotImplementedException();
        }

        public void Update(AssemblyPropertyViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
