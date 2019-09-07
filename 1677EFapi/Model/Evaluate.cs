using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 详情表
    /// </summary>
    public class Evaluate
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 评价内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Pid
        /// </summary>
        public int Pid { get; set; }
    }
}
