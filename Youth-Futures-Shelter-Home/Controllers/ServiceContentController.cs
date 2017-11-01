using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YouthFuturesShelterHome.Models;

namespace Youth_Futures_Shelter_Home.Controllers
{
    public class ServiceContentController : Controller
    {
        CMSDBDataContext context = new CMSDBDataContext();
        public IActionResult Index()
        {
            return NewMethod();
        }

        private IActionResult NewMethod()
        {
            return View(context.Services.ToList());
        }
    }
}