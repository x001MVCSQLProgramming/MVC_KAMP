using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Author
    {
        [Key]
        public int author_ID { get; set; }

        [StringLength(50)]
        public string author_name { get; set; }

        [StringLength(50)]
        public string author_surname { get; set; }

        [StringLength(100)]
        public string author_image { get; set; }

        [StringLength(50)]
        public string author_email { get; set; }

        [StringLength(20)]
        public string author_password { get; set; }

        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
