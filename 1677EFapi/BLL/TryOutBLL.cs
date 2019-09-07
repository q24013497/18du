using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;


namespace BLL
{
    public class TryOutBLL
    {
        TryOutDAL dal = new TryOutDAL();
        public List<TryOut> GetTryOut()
        {
            return dal.GetTryOut();
        }
    }
}
