using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
namespace Business
{
    public class B_Storage
    {
        public List<Storage> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
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
