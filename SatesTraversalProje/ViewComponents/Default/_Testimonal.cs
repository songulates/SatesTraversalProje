using BusinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatesTraversalProje.ViewComponents.Default
{
    public class _Testimonal:ViewComponent
    {
        TestimonalManager testimonalManager = new TestimonalManager(new EfTestimonal());
        public IViewComponentResult Invoke()
        {
            var values = testimonalManager.TGetList();
            return View(values);
        }
    }
}
