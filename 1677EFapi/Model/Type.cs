using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{/// <summary>
/// 类型表
/// </summary>
 public   class Type
    {/// <summary>
    /// 主键
    /// </summary>
        [Key]
    
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Pid
        /// </summary>
        public int Pid { get; set; }
    }
}
