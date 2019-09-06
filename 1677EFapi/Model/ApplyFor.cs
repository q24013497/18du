using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{/// <summary>
/// 申请表
/// </summary>
  public  class ApplyFor
    {/// <summary>
    /// 主键
    /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品类型Id
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 商品店铺Id
        /// </summary>
        public int ShopId { get; set; }
        /// <summary>
        /// 交易状态Id
        /// </summary>
        public int StatuId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
    }
}
