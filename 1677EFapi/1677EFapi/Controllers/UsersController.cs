﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;
using Model;
namespace _1677EFapi.Controllers
{
    [Route("api/[controller]/action")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        CollectBLL bll = new CollectBLL();

        [HttpGet]
        public List<Collect> GetUser()

        {
            var USers =  bll.GetUser();
            return USers;
        }
    }
}