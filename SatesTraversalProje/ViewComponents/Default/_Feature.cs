using BusinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatesTraversalProje.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeature());
        public IViewComponentResult Invoke()
        {
            //var values = featureManager.TGetList();
            return View(/*values*/);
        }
    }
}
