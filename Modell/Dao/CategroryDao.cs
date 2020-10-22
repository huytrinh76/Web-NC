using Modell.EF;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell.Dao
{
    public class CategroryDao
    {
        XePKLDbContext db = null;
        public CategroryDao()
        {
            db = new XePKLDbContext();
        }

        public List<Categrory> ListAll()
        {
            return db.Categrories.Where(x => x.Status == true).ToList();
        }
        public DanhmucSP ViewDetail(long id)
        {
            return db.DanhmucSPs.Find(id); 
        }
    }
}
