using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class MasterDAL1
    {
        DataContext db = new DataContext();
        public List<Master> GetMasters1()
        {
            return db.Master.ToList();
        }
    }
}
