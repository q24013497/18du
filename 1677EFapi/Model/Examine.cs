using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 审批表
    /// </summary>
   public class Examine
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 审批ID
        /// </summary>
        public int Examineid { get; set; }
        /// <summary>
        /// 审批人
        /// </summary>
        public string Persone { get; set; }
        /// <summary>
        /// 状态Id
        /// </summary>
        public int StatuId { get; set; }
        /// <summary>
        /// 意见
        /// </summary>
        public string Opinion { get; set; }
    }
}
