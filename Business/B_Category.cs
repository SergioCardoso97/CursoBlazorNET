using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
namespace Business
{
    public class B_Category
    {
        public List<Category> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }
        public Category CategoryById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList().LastOrDefault(x => x.CategoryId == id);
            }
        }
        public void CreatedCategory(Category oCategory)
        {
            using(var db = new InventaryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }
        public void UpdateCategory(Category oCategory)
        {
            using( var db = new InventaryContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }
        public void DeleteCategory(Category oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Remove(oCategory);
                db.SaveChanges();
            }
        }

    }
}
