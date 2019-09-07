using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using BLL;

namespace _1677EFapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TryOutController : ControllerBase
    {
        TryOutBLL bll = new TryOutBLL();

        [HttpGet]
        public List<TryOut> GetTryOut()
        {
            return bll.GetTryOut();
        }
    }
}