﻿using LogicaProgramacao.Classes.Assembly;
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

        public void Delete(int Id)
        {
            var context = new CursoDEVEntities();

            var modelCustomer = context.Customers.Where(x => x.Id == Id).FirstOrDefault();

            context.Customers.Remove(modelCustomer);

            //commit
            context.SaveChanges();
        }

        public List<CustomerViewModel> List()
        {
            var context = new CursoDEVEntities();
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
            var context = new CursoDEVEntities();

            var modelTemp = context.Customers.FirstOrDefault(x => x.Id == model.Id);

            modelTemp.CustomerName = model.CustomerName;
            modelTemp.Active = model.Active;

            context.SaveChanges();
        }

        public void RemovelAllContainsCharS()
        {
            var context = new CursoDEVEntities();

            var list = context.Customers.Where(x => x.CustomerName.ToUpper().Contains("S")).ToList();

            context.Customers.RemoveRange(list);

            context.SaveChanges();
        }
    }
}
