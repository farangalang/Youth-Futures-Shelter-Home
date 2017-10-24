using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Youth_Futures_Shelter_Home.ViewComponents
{
    
    public class ServicesViewComponent : ViewComponent
    {
        
        
            public async Task<IViewComponentResult> InvokeAsync()
            {
                var services = new List<ServicesItem>()
                {
                    new ServicesItem() { Title = "s1", Description = "d1"},
                    new ServicesItem() { Title = "s2", Description = "d2"}
                };

                return View(services);
            }
        
    }

    public class ServicesItem
    {

        public ServicesItem()
        {
            
        }
        

        public string Description { get; set; }
        public string Title { get; set; }
    }

    
}
