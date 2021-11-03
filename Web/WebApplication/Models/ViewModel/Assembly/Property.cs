using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Models.DB;
using WinForms.Classes.Entity;

namespace LogicaProgramacao.Classes.Assembly
{
    public class PropertyViewModel : ClassBase
    {
        public string PropertyName { get; set; }

        public static PropertyViewModel ReturnClassBase(Property property)
        {
            PropertyViewModel propertyViewModel = new PropertyViewModel();
            propertyViewModel.Id = property.Id;
            propertyViewModel.PropertyName = property.PropertyName;
            propertyViewModel.Active = property.Active;

            return propertyViewModel;
        }
    }
}
