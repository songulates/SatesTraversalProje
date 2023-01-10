using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    //T parametresi entitye karşılık gelmektedir.
   public interface IGenericDal<T>
    {
        void Insert(T t); //ınsert netodu  T türünde t parametresi al
        void Update(T t);
        void Delete(T t);
        List<T> GetList();
    }
}
