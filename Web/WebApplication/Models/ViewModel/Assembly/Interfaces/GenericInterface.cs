using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao.Classes.Assembly.Interfaces
{
    public interface GenericInterface<T> where T: class
    {
        int Add(T model);
        void Update(T model);
        void Delete(int Id);
        List<T> List();
    }
}
