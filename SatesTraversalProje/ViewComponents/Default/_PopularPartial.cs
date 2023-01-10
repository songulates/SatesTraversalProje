using BusinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatesTraversalProje.ViewComponents.Default
{
    public class _PopularPartial:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinition());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
