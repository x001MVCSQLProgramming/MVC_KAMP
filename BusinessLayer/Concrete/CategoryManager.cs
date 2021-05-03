using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if (p.category_name=="" || p.category_name.Length<=3 || p.category_description=="" || p.category_name.Length>=51)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    } 
}
