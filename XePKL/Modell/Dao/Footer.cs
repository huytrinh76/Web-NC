using Modell.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell.Dao
{
    public class FooterDao
    {
        XePKLDbContext db = null;

        public FooterDao()
        {
            db = new XePKLDbContext();
        }

        public Footer GetFooter()
        {
            return db.Footers.SingleOrDefault(x => x.Status == true);
        }
    }
}
