using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YouthFuturesShelterHome.Models
{
    [Table(name: "Voulnteer")]
    public class VoulnteerContent
    {
        public int voulnteerID { get; set; }
        public string imagePath { get; set; }
        public string header_text { get; set; }
        public string  link_text { get; set; }
    }
}
