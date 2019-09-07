using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL
{
    public class TryOutDAL
    {
        DataContext db = new DataContext();

        public List<TryOut> GetTryOut()
        {
            return db.TryOut.ToList();
        }
    }
}
