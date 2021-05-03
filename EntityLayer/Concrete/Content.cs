using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {

        [Key]
        public int content_ID { get; set; }

        [StringLength(1000)]
        public string content_value { get; set; }

        public DateTime content_date { get; set; }
        //ContentAuthor
        //ContentHeading

        public int heading_ID { get; set; }
        public virtual Heading Heading { get; set; }

        public int? author_ID { get; set; }
        public virtual Author Author { get; set; }

    }
}
