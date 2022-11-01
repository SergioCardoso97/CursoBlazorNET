using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
using Microsoft.EntityFrameworkCore;
namespace Business
{
    public class B_Storage
    {
        public List<Storage> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.Include(s => s.Product).Include(s => s.Warehouse).ToList();
            }
        }
        public List<Storage> StorageProductsByWarehouse(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.Include(x => x.Product).
                Include(x => x.Warehouse).
                Where(x => x.WarehouseId == idWarehouse).ToList();
            }
        }
        public void CreatedStorage(Storage oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }
        public bool IsProductInWarehouse(string id)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList().Where(x => x.StorageId == id);
                return product.Any();
            }
        }
        public void UpdateStorage(Storage oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
        public void DeleteStorage(Storage oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Remove(oStorage);
                db.SaveChanges();
            }
        }
    }
}
