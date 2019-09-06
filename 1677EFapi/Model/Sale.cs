using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 秒杀表
    /// </summary>
   public class Sale
    {
        [Key]
        public int Id { get; set; }//主键
        public string Name { get; set; }//商品名称
        public int Price { get; set; }//市场价
        public int ProPay { get; set; }//秒杀价
        public int Sales { get; set; }//限量
        public string Color { get; set; }//颜色
        public int Number { get; set; }//数量
        public int ShopId { get; set; }//店铺Id
        public DateTime StartTime { get; set; }//开始时间
        public DateTime EndTime { get; set; }//结束时间
    }
}
