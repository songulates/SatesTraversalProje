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
    public class TestimonalManager : ITestimonalService
    {
        ITestimonalDal _testimonalDal;

        public TestimonalManager(ITestimonalDal testimonalDal)
        {
            _testimonalDal = testimonalDal;
        }

        public Testimonal GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Testimonal t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonal t)
        {
            throw new NotImplementedException();
        }

        public List<Testimonal> TGetList()
        {
            return _testimonalDal.GetList();
        }

        public void TUpdate(Testimonal t)
        {
            throw new NotImplementedException();
        }
    }
}
