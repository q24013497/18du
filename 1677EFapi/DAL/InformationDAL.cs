using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class InformationDAL
    {
        DataContext db = new DataContext();
        public List<Information> GetInformation()
        {
            var list = db.Information.Join(db.Evaluate, Information => Information.DetailId, Evaluate => Evaluate.Id, (Information, Evaluate) => new Information
            {
                Id = Information.Id,
                Name = Information.Name,
                Informationintroduced = Information.Informationintroduced,
                Price = Information.Price,
                Content = Evaluate.Content
            }).ToList();
            //var list= (from i in db.Information
            //    join e in db.Evaluate on i.DetailId equals e.Id into e_join
            //    from x in e_join.DefaultIfEmpty()
            //    join a in db.Images on i.Image equals a.Id into a_join
            //    from v in a_join.DefaultIfEmpty()
            //    select new
            //    {
            //        id = u.id,
            //        name = u.name,
            //        jname = x.jname,
            //        cname = v.cname,
            //        /*u1=u,x1=x,v1=v*///不要用对象的方式 因为对象可能为null那么对象.属性就会抛异常
            //    }).ToList();
            return list;
        }
        public int AddInformation(Information ct)
        {
            db.Information.Add(ct);
            return db.SaveChanges();


        }

        public int DeleteInformation(int id)
        {
            Information ct = new Information { Id = id };
            db.Entry(ct).State = EntityState.Deleted;
            return db.SaveChanges();
        }
        public Information Fan(int id)
        {
            return db.Information.Where(u => u.Id == id).FirstOrDefault();
        }
        public int UpdateInformation(Information ct)
        {
            db.Information.Add(ct);
            db.Entry(ct).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
