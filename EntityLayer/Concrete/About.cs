using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int about_ID { get; set; }

        [StringLength(1000)]
        public string about_details1 { get; set; }

        [StringLength(1000)]
        public string about_details2 { get; set; }

        [StringLength(100)]
        public string about_image1 { get; set; }

        [StringLength(100)]
        public string about_image2 { get; set; }
    }
}
