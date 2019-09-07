using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DAL
{
    public class MasterDAL
    {
        DataContext db = new DataContext();
        public List<Master> GetMasters()
        {
            return db.Master.ToList();
        }
    }
}
