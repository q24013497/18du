using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 试用表
    /// </summary>
    public class TryOut
    {

        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 原市场价格
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 会员价格
        /// </summary>
        public int ProPay { get; set; }

        /// <summary>
        /// 限购数量
        /// </summary>
        public int Sales { get; set; }

        /// <summary>
        /// 积分限制
        /// </summary>
        public int Integral { get; set; }

        /// <summary>
        /// 物品类别Id
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 商品简介
        /// </summary>
        public string About { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        public DateTime EndTime { get; set; }

    }
}
