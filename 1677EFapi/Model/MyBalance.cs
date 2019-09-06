using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
   public class MyBalance
    {/// <summary>
    /// 主键Id
    /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 积分总数
        /// </summary>
        public float Sum { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Statu { get; set; }
        /// <summary>
        /// 支出/支入分数
        /// </summary>
        public float Deal { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
    }
}
