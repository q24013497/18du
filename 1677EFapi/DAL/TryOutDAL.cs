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

        /// <summary>
        /// 显示所有
        /// </summary>
        /// <returns></returns>
        public List<TryOut> GetTryOut()
        {
            return db.TryOut.ToList();
        }

        /// <summary>
        /// 添加方法
        /// </summary>
        /// <param name="tryOut"></param>
        /// <returns></returns>
        public int AddTryOut(TryOut tryOut)
        {
            db.TryOut.Add(tryOut);
            return db.SaveChanges();
        }
    }
}
