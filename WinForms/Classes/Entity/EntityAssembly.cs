using LogicaProgramacao.Classes.Assembly;
using LogicaProgramacao.Classes.Assembly.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Classes.Entity
{
    public class EntityAssembly : GenericInterface<AssemblyViewModel>
    {
        public void Add(AssemblyViewModel model)
        {
            var context = new CursoDEVEntities();

            Assembly assembly = new Assembly();
            assembly.Name = model.AssemblyName;
            assembly.Active = model.Active;
            assembly.FK_Factory = model.Factory.Id;
            assembly.FK_Customer = model.Customer.Id;

            context.Assemblies.Add(assembly);

            context.SaveChanges();

        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<AssemblyViewModel> List()
        {
            throw new NotImplementedException();
        }

        public void Update(AssemblyViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
