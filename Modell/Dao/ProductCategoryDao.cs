using Modell.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell.Dao
{
    public class ProductCategoryDao
    {
        XePKLDbContext db = null;
        public ProductCategoryDao()
        {
            db = new XePKLDbContext();

        }
        public List<DanhmucSP> ListAll()
        {
            return db.DanhmucSPs.Where(x => x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
        }
        
        public DanhmucSP ViewDetail(long id)
        {
            return db.DanhmucSPs.Find(id);
        }

    }
}
