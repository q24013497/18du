using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 积分表
    /// </summary>
    public class Integral
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 标题名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 原市场价格
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 所需积分
        /// </summary>
        public int Required { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        public int Sales { get; set; }

        /// <summary>
        /// 库存量
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 服务
        /// </summary>

        public string Saas { get; set; }

        /// <summary>
        /// 图片
        /// </summary>

        public string Image { get; set; }
        /// <summary>
        /// 商品详情id
        /// </summary>
        public int Details { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>

        public DateTime CreateTime { get; set; }
    }
}
