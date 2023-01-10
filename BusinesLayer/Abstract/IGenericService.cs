using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
    //concrete tarafında yapılacak business metodların imzasi atılcak
    public interface IGenericService<T>
    {
        void TAdd(T t); //ınsert netodu  T türünde t parametresi al
        void TUpdate(T t);
        void TDelete(T t);
        List<T> TGetList();
        T GetById(int id);
    }
}
