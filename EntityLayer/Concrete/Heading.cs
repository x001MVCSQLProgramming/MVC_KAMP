using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int heading_ID { get; set; }

        [StringLength(50)]
        public string heading_name { get; set; }

        public DateTime heading_date { get; set; }

        public int category_ID { get; set; }
        public virtual Category Category { get; set; }

        public int? author_ID { get; set; }
        public virtual Author Author { get; set; }

        public ICollection<Content> Contents { get; set; }
        
    }
}
