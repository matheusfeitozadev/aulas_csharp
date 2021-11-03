using LogicaProgramacao.Classes.Assembly;
using LogicaProgramacao.Classes.Assembly.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Models.DB;

namespace WinForms.Classes.Entity
{
    public class EntityAssembly : GenericInterface<AssemblyViewModel>
    {
        public int Add(AssemblyViewModel model)
        {
            var context = new CursoDEVContext();

            WebApplication.Models.DB.Assembly assembly = new WebApplication.Models.DB.Assembly();
            assembly.Name = model.AssemblyName;
            assembly.Active = model.Active;
            assembly.FK_Factory = model.Factory.Id;
            assembly.FK_Customer = model.Customer.Id;

            assembly = context.Assemblies.Add(assembly);

            context.SaveChanges();

            return assembly.Id;
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
