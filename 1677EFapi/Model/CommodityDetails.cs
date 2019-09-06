using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 商品详情表
    /// </summary>
   public class CommodityDetails
    {/// <summary>
    /// 主键
    /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 商品Id
        /// </summary>
        public int ImageId { get; set; }
        /// <summary>
        /// 详情介绍
        /// </summary>
        public string DetailIntroduce { get; set; }
    }
}
