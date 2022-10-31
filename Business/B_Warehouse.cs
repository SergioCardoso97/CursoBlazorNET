using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Business
{
    public class B_Warehouse
    {

        public List<Warehouse> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }
        public Warehouse WarehouseById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList().LastOrDefault(x => x.WarehouseId == id);
            }
        }
        public void CreatedWarehouse(Warehouse oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }
        public void UpdateWarehouse(Warehouse oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
        public void DeleteWarehouse(Warehouse oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Remove(oWarehouse);
                db.SaveChanges();
            }
        }


    }
}
