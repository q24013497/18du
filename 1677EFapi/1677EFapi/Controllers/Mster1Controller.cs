using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace _1677EFapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mster1Controller : ControllerBase
    {
        Master1BLL bll = new Master1BLL();

        [HttpGet]
        public List<Master> GetMaster()
        {
            List<Master> Masters1 = bll.GetMasters1();
            return Masters1;
        }
    }
}