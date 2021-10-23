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
