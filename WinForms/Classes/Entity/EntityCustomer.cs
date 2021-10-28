using LogicaProgramacao.Classes.Assembly;
using LogicaProgramacao.Classes.Assembly.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Classes.Entity
{
    public class EntityCustomer : GenericInterface<CustomerViewModel>
    {
        public void Add(CustomerViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomerViewModel Id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerViewModel> List()
        {
            var context = new CursoDEVContext();
            List<CustomerViewModel> listViewModel = new List<CustomerViewModel>();

            var list = context.Customers.ToList();

            foreach (var item in list)
            {
                listViewModel.Add(CustomerViewModel.ReturnClassBase(item));
            }

            return listViewModel;
        }

        public void Update(CustomerViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
