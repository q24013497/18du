using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
    public class CollectBLL
    {
        CollectDAL dl= new CollectDAL();

        public List<Collect> GetUser()
        {
            return dl.GetUser();
        }
        public int AddCollect(Collect ct)
        {

            return dl.AddCollect(ct);


        }

        public int DeleteCollect(int id)
        {

            return dl.DeleteCollect(id);
        }
        public Collect Fan(int id)
        {
            return dl.Fan(id);
        }
        public int UpdateCollect(Collect ct)
        {

            return dl.UpdateCollect(ct);
        }
    }
}
