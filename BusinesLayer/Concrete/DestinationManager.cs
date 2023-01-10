using BusinesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class DestinationManager: IDestinitionService
    {
        IDestinitionDal _destinitionDal;

        public DestinationManager(IDestinitionDal destinitionDal)
        {
            _destinitionDal = destinitionDal;
        }

        public Destinition GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Destinition t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destinition t)
        {
            throw new NotImplementedException();
        }

        public List<Destinition> TGetList()
        {
            return _destinitionDal.GetList();
        }

        public void TUpdate(Destinition t)
        {
            throw new NotImplementedException();
        }
    }
}
