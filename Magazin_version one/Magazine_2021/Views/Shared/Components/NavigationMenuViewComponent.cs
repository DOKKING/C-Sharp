using Magazine_2021.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazine_2021.Views.Shared.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        CarContext db;

        public NavigationMenuViewComponent(CarContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(db.CategoryTable.Select(c=>c.categoryName).Distinct().OrderBy(x=>x));
        }
    }
}
