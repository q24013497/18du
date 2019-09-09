using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using _1677Web.Models;

namespace _1677Web.Controllers
{
    public class TryOutController : Controller
    {
        //public IActionResult Index()
        //{
        //    List<TryOut> lst = GetTryOuts();
        //    return View(lst);
        //}
        //public List<TryOut> GetTryOuts()
        //{
        //    //定义HTTP访问对象
        //    HttpClient httpClient = new HttpClient();
        //    //声明访问地址
        //    httpClient.BaseAddress = new Uri("http://localhost:53782/");
        //    //设置访问数据格式
        //    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    //获取相应对象
        //    var response = httpClient.GetAsync("api/TryOut/GetTryOut").Result;
        //    string strResult = "";
        //    if (response.IsSuccessStatusCode)
        //    {
        //        //返回的数据结果
        //        strResult = response.Content.ReadAsStringAsync().Result;
        //    }
        //    httpClient.Dispose();

        //    return JsonConvert.DeserializeObject<List<TryOut>>(strResult);
        //}
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowIndex()
        {
            return View();
        }
    }
}