using LogicaProgramacao.Classes.Assembly.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao.Classes.Assembly
{
    public class Customer : ClassBase, GenericInterface<Customer>
    {
        public string CustomerName { get; set; }

        public Customer()
        {

        }

        public Customer(string customer, bool active)
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


        public static List<Customer> GetList()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer()
            {
                Id = 54,
                CustomerName = "POSITIVO",
                Active = true
            });

            customers.Add(new Customer()
            {
                Id = 42,
                CustomerName = "SAMSUNG",
                Active = true
            });

            customers.Add(new Customer()
            {
                Id = 65,
                CustomerName = "JCH",
                Active = true
            });

            return customers;
        }

        public void Add(Customer model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer Id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer model)
        {
            throw new NotImplementedException();
        }
    }
}
