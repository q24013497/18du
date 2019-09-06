using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model;
namespace DAL
{
    public class CollectDAL
    {
        DataContext db = new DataContext();
        public List<Collect> GetUser()
        {
            return db.Collect.ToList();
        }
        public int AddCollect(Collect ct)
        {
           db.Collect.Add(ct);
            return db.SaveChanges();

            
        }

        public int DeleteCollect(int id)
        {
            Collect ct = new Collect { Id = id };
            db.Entry(ct).State = EntityState.Deleted;
            return db.SaveChanges();
        }
        public Collect Fan(int id)
        {
            return db.Collect.Where(u => u.Id== id).FirstOrDefault();
        }
        public int UpdateCollect(Collect ct)
        {
            db.Collect.Add(ct);
            db.Entry(ct).State = EntityState.Modified;
            return db.SaveChanges();
        }


    }
}
