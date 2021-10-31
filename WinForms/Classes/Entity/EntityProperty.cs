using LogicaProgramacao.Classes.Assembly;
using LogicaProgramacao.Classes.Assembly.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Classes.Entity
{
    public class EntityProperty : GenericInterface<PropertyViewModel>
    {
        public int Add(PropertyViewModel model)
        {
            var context = new CursoDEVEntities();

            Property property = new Property();
            property.PropertyName = model.PropertyName;
            property.Active = model.Active;

            property = context.Properties.Add(property);

            context.SaveChanges();

            return property.Id;
        }

        public void Delete(int Id)
        {
            var context = new CursoDEVEntities();

            var modelFactory = context.Properties.Where(x => x.Id == Id).FirstOrDefault();

            context.Properties.Remove(modelFactory);

            //commit
            context.SaveChanges();
        }

        public List<PropertyViewModel> List()
        {
            var context = new CursoDEVEntities();
            List<PropertyViewModel> listViewModel = new List<PropertyViewModel>();

            var list = context.Properties.ToList();

            foreach (var item in list)
            {
                listViewModel.Add(PropertyViewModel.ReturnClassBase(item));
            }

            return listViewModel;
        }

        public void Update(PropertyViewModel model)
        {
            var context = new CursoDEVEntities();

            var modelTemp = context.Properties.FirstOrDefault(x => x.Id == model.Id);

            modelTemp.PropertyName = model.PropertyName;
            modelTemp.Active = model.Active;

            context.SaveChanges();
        }

        public bool Exists(PropertyViewModel propertyViewModel)
        {
            var context = new CursoDEVEntities();

            return context.Properties.Any(x => x.PropertyName.ToUpper().Equals(propertyViewModel.PropertyName.Trim().ToUpper()));
        }
    }
}
