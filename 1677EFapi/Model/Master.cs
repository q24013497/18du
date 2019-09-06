using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 主表
    /// </summary>
    public class Master
    {
        [Key]
        public int Id { get; set; }//主键

        public string Name { get; set; }//商品名称
        public int MarketPrice { get; set; }//市场价格 
        public int ProPay { get; set; }//  会员价格
        public int Sales { get; set; }//销量
        public int SKU { get; set; }//剩余库存量
        public int OriginId { get; set; }//品牌Id
        public int ShopId { get; set; }//店铺Id
        public string Saas { get; set; }//所提供服务
        public string Image { get; set; }//图片
        public string Details { get; set; }//商品详情
        public string StoreType { get; set; }//店铺类型
        public DateTime CreateTime { get; set; }//创建时间
    }
}
