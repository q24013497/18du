using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{/// <summary>
/// 购物车
/// </summary>
   public class Cart
    {/// <summary>
    /// 主键Id
    /// </summary>
    [Key]
        public int Id { get; set; }
        /// <summary>
        /// 主表Id
        /// </summary>
        public int MasterId { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }///
    }
}
