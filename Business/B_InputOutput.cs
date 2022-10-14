using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
namespace Business
{
    public class B_InputOutput
    {
        public List<InputOutput> InputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }
        public void CreatedInputOutput(InputOutput oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInputOutput);
                db.SaveChanges();
            }
        }
        public void UpdateInputOutput(InputOutput oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInputOutput);
                db.SaveChanges();
            }
        }
        public void DeleteInputOutput(InputOutput oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Remove(oInputOutput);
                db.SaveChanges();
            }
        }
    }
}
