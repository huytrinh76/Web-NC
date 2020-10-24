using Modell.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell.Dao
{
    public class OrderDetailDao
    {
        XePKLDbContext db = null;
        public OrderDetailDao()
        {
            db = new XePKLDbContext();
        }
        public bool Insert(OrderDetail detail)
        {
            try
            {
                db.OrderDetails.Add(detail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
