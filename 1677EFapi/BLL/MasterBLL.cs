﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class MasterBLL
    {
        MasterDAL dal = new MasterDAL();
        public List<Master> GetMasters()
        {
            return dal.GetMasters();
        }
    }
}
