using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 商品简介
    /// </summary>
   public class ProductIntroduction
    {
        /// <summary>
        /// 主键
        /// </summary>
        /// 
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        public string Modell { get; set; }
        /// <summary>
        /// 产品重量
        /// </summary>
        public float ProductWeight { get; set; }
    }
}
