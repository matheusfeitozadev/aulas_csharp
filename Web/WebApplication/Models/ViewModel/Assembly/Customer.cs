using LogicaProgramacao.Classes.Assembly.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Models.DB;
using WinForms.Classes.Entity;

namespace LogicaProgramacao.Classes.Assembly
{
    public class CustomerViewModel : ClassBase
    {
        public string CustomerName { get; set; }

        public CustomerViewModel()
        {

        }

        public CustomerViewModel(int id)
        {
            Id = id;
        }

        public CustomerViewModel(string customer, bool active)
        {
            CustomerName = customer;
            Active = active;
        }

        public string CheckInformation()
        {
            var message = "";

            if(string.IsNullOrEmpty(CustomerName))
            {
                message = "Customer name is empty!";
            }

            return message;
        }


        public static List<CustomerViewModel> GetList()
        {
            List<CustomerViewModel> customers = new List<CustomerViewModel>();

            customers.Add(new CustomerViewModel()
            {
                Id = 54,
                CustomerName = "POSITIVO",
                Active = true
            });

            customers.Add(new CustomerViewModel()
            {
                Id = 42,
                CustomerName = "SAMSUNG",
                Active = true
            });

            customers.Add(new CustomerViewModel()
            {
                Id = 65,
                CustomerName = "JCH",
                Active = false
            });

            return customers;
        }

        public static CustomerViewModel ReturnClassBase(Customer customer)
        {
            var model = new CustomerViewModel();
            model.Id = customer.Id;
            model.CustomerName = customer.CustomerName;
            model.Active = customer.Active;

            return model;
        }
    }
}
