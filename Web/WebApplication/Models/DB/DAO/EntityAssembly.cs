using LogicaProgramacao.Classes.Assembly;
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
            List<AssemblyViewModel> listModel = new List<AssemblyViewModel>();
            var context = new CursoDEVContext();

            var list = context.Assemblies.ToList();

            foreach(var item in list)
            {
                AssemblyViewModel itemAssembly = new AssemblyViewModel();
                itemAssembly.Id = item.Id;
                itemAssembly.AssemblyName = item.Name;
                itemAssembly.Factory = FactoryViewModel.ReturnClassBase(item.Factory);
                itemAssembly.Customer = CustomerViewModel.ReturnClassBase(item.Customer);
                itemAssembly.Properties = new List<AssemblyPropertyViewModel>();

                foreach (var itemProp in item.AssemblyProperties)
                {
                    itemAssembly.Properties.Add(new AssemblyPropertyViewModel()
                    {
                        Id = itemProp.Id
                    });
                }

                listModel.Add(itemAssembly);
            }

            return listModel;
        }

        public void Update(AssemblyViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
