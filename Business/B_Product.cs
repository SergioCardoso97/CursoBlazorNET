using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
namespace Business
{
    public class B_Product
    {
        public List<Product> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }
        public void CreatedProduct(Product oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }
        public void UpdateProduct(Product oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }
        public void DeleteProduct(Product oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Remove(oProduct);
                db.SaveChanges();
            }
        }
    }
}
