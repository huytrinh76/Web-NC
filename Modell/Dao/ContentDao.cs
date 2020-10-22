using Modell.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell.Dao
{
    public class ContentDao
    {
        XePKLDbContext db = null;
        public ContentDao()
        {
            db = new XePKLDbContext();
        }

        public Content GetByID(long id)
        {
            return db.Contents.Find(id);
        }
    }
}
