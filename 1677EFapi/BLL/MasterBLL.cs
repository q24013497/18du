using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class MasterBLL
    {
        MasterDAL dal = new MasterDAL();
        public List<Master> GetMasters(int id)
        {
            return dal.GetMasters(id);
        }
        public int AddTrade(Trade trade)
        {
            return dal.AddTrade(trade); 
        }
    }
}
