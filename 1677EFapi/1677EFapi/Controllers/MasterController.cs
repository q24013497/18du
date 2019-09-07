using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL;
using Model;

namespace _1677EFapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : Controller
    {
        MasterBLL bll = new MasterBLL();

        [HttpGet]
        public List<Master> GetMaster()
        {
            List<Master> Masters = bll.GetMasters();
            return Masters;
        }
    }
}