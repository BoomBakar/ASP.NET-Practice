using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponentSample.Models;

namespace WebApplication7.Views.ViewComponents
{
    public class detailsViewComponent : ViewComponent
    {
        public IViewComponent Invoke()
        {
            return View();
        }
    }
}
