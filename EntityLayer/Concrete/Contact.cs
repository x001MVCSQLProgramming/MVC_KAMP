using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int contact_ID { get; set; }

        [StringLength(50)]
        public string user_name { get; set; }
        
        [StringLength(50)]
        public string user_mail { get; set; }

        [StringLength(50)]
        public string subject { get; set; }

        [StringLength(1000)]
        public string message { get; set; }


    }
}
