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
                    new ServicesItem() { Image = "/images/house_icon.png", Alt = "House", Title = "Overnight Shelter", Description = "Located in the heart of downtown Ogden, Utah, Youth Futures provides emergency shelter, temporary residence and supportive services for runaway, homeless, unaccompanied and at-risk youth ages 12-17. The shelter is open 24 hours per day."},
                    new ServicesItem() { Image = "/images/door_icon.png", Alt = "Door", Title = "Drop-in Services", Description = "Available to any youth ages 12-18. Drop-in services allow for the youth to access food, clothing, hygiene items, laundry facilities, computer stations, and case management. Drop-in hours are 6:30 am to 8:00 pm every day of the week."},
                    new ServicesItem() { Image = "/images/van_icon.png", Alt = "Van", Title = "Street Outreach", Description = "Youth Futures’ Street Outreach is conducted once per week and provides outreach and crisis services to youth in Ogden City, Utah."},
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
        public string Image { get; set; }
        public string Alt { get; set; }
    }

    
}
