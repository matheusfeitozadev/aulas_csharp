using LogicaProgramacao.Classes.Assembly.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Active = false
            });

            return customers;
        }

        public static ListViewItem[] FillListView(List<Customer> customers)
        {
            List<ListViewItem> list = new List<ListViewItem>();

            foreach (var item in customers)
            {
                string[] values = {
                    item.Id.ToString(),
                    item.CustomerName,
                    item.Active.ToString()
                };

                ListViewItem row = new ListViewItem(values);

                list.Add(row);
            }

            return list.ToArray();
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
