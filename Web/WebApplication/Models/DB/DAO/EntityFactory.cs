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
    public class EntityFactory : GenericInterface<FactoryViewModel>
    {
        public int Add(FactoryViewModel model)
        {
            var context = new CursoDEVContext();

            Factory factory = new Factory();
            factory.Name = model.Name;
            factory.Active = model.Active;

            factory = context.Factories.Add(factory);

            context.SaveChanges();

            return factory.Id;
        }

        public void Delete(int Id)
        {
            var context = new CursoDEVContext();

            var modelFactory = context.Factories.Where(x => x.Id == Id).FirstOrDefault();

            context.Factories.Remove(modelFactory);

            //commit
            context.SaveChanges();
        }

        public List<FactoryViewModel> List()
        {
            var context = new CursoDEVContext();
            List<FactoryViewModel> listViewModel = new List<FactoryViewModel>();

            var list = context.Factories.ToList();

            foreach (var item in list)
            {
                listViewModel.Add(FactoryViewModel.ReturnClassBase(item));
            }

            return listViewModel;
        }

        public void Update(FactoryViewModel model)
        {
            var context = new CursoDEVContext();

            var modelTemp = context.Factories.FirstOrDefault(x => x.Id == model.Id);

            modelTemp.Name = model.Name;
            modelTemp.Active = model.Active;

            context.SaveChanges();
        }

        public bool Exists(FactoryViewModel factoryViewModel)
        {
            var context = new CursoDEVContext();

            return context.Factories.Any(x => x.Name.ToUpper().Equals(factoryViewModel.Name.Trim().ToUpper()));
        }
    }
}
