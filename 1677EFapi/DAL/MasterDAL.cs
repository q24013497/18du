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
        public List<Master> GetMasters(int id)
        {
            if (id == 0)
            {
                return db.Master.ToList();
            }
            else
            {
                return db.Master.Where(u => u.Id == id).ToList();
            }
           
        }
        public int AddTrade(Trade trade)
        {
            db.Trade.Add(trade);
            return db.SaveChanges();
        }
    }
}
