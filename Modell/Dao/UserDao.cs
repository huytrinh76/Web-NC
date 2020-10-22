using Modell.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagedList.Mvc;
using System.Threading.Tasks;
using PagedList;

namespace Modell.Dao
{
    public class UserDao
    {
        XePKLDbContext db = null;
        public UserDao()
        {
            db = new XePKLDbContext();
        }

        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public bool Update(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.ID);
                user.Name = entity.Name;
                if (string.IsNullOrEmpty(entity.Password))
                {
                    user.Password = entity.Password
;                }
                user.Address = entity.Address;
                user.Email = entity.Email;
                user.ModifiedBy = entity.ModifiedBy;
                user.CreateData = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                //logging
                return false;
            }
            
        }

        public IEnumerable<User> ListAllPaging(string searchString,int page , int pageSize)
        {
            IQueryable<User> model = db.Users;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.UserName.Contains(searchString) || x.Name.Contains(searchString));
            }
            return model.OrderByDescending(x=>x.CreateData).ToPagedList(page,pageSize);
        }

        public User GetByID(string userName)
        {
            return db.Users.SingleOrDefault(x =>x.UserName == userName);
        }

        public User ViewDetail(int id)
        {
            return db.Users.Find(id);
        }

        public int Login (string userName,string passWord)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if(result.Status == false)
                {
                    return -1;
                }
                else
                {
                    if (result.Password == passWord)
                        return 1;
                    else
                        return -2;
                }    
            }
        }
        public bool ChangeStatus(long id)
        {
            var user = db.Users.Find(id);
            user.Status = !user.Status;
            db.SaveChanges();
            user.Status = !user.Status;

            return user.Status;
        } 
        public bool Delete(int id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
         
        }
    }
}
