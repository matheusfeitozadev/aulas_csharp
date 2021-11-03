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
    public class EntityCustomer : GenericInterface<CustomerViewModel>
    {
        public int Add(CustomerViewModel model)
        {
            var context = new CursoDEVContext();

            Customer customer = new Customer();
            customer.CustomerName = model.CustomerName;
            customer.Active = model.Active;

            customer = context.Customers.Add(customer);

            context.SaveChanges();

            return customer.Id;
        }

        public void Delete(int Id)
        {
            var context = new CursoDEVContext();

            var modelCustomer = context.Customers.Where(x => x.Id == Id).FirstOrDefault();

            context.Customers.Remove(modelCustomer);

            //commit
            context.SaveChanges();
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
            var context = new CursoDEVContext();

            var modelTemp = context.Customers.FirstOrDefault(x => x.Id == model.Id);

            modelTemp.CustomerName = model.CustomerName;
            modelTemp.Active = model.Active;

            context.SaveChanges();
        }

        public void RemovelAllContainsCharS()
        {
            var context = new CursoDEVContext();

            var list = context.Customers.Where(x => x.CustomerName.ToUpper().Contains("S")).ToList();

            context.Customers.RemoveRange(list);

            context.SaveChanges();
        }

        public bool Exists(CustomerViewModel customerViewModel)
        {
            var context = new CursoDEVContext();

            return context.Customers.Any(x => x.CustomerName.ToUpper().Equals(customerViewModel.CustomerName.Trim().ToUpper()));
        }
    }
}
