using Modell.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell.Dao
{
    public class SlideDao
    {
        XePKLDbContext db = null;
        public SlideDao()
        {
            db = new XePKLDbContext();
        }

        public List<Slide> ListAll()
        {
            return db.Slides.Where(x => x.Status == true).OrderBy(y => y.DisplayOrder).ToList();

        }
    }
}