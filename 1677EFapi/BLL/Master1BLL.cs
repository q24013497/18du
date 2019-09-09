using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
   public class Master1BLL
    {
        MasterDAL dal = new MasterDAL();
        public List<Master> GetMasters1()
        {
            return dal.GetMasters1();
        }
    }
}
