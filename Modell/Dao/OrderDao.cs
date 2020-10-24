using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modell.EF;

namespace Modell.Dao
{
    public class OrderDao
    {
        XePKLDbContext db = null;
        public OrderDao()
        {
            db = new XePKLDbContext();
        }
        public long Insert(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order.ID;
        }
    }
}
