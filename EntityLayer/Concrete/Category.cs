using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {

        [Key]
        public int category_ID { get; set; }

        [StringLength(50)]
        public string category_name { get; set; }

        [StringLength(200)]
        public string category_description { get; set; }


        public bool category_status { get; set; }//Kategori silme yapmayacağız. Durumu aktif/pasif yapacağız.Neden? Örneğin yazılım kategorisini sildiğimde elimdeki tüm yazılımla alakaı içerikler girmesin diye.

        public ICollection<Heading> Headings { get; set; }
       

    }
}
