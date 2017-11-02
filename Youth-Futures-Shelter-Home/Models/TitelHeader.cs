using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace YouthFuturesShelterHome.Models
{
    public class TitelHeader
    {
        [Table(name: "TitleHeaders")]
        public class TitleHeaders
        {
            public int TDID { get; set; }
            public string Text { get; set; }
        }

    }
}

