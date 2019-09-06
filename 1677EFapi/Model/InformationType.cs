using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 资讯类型表
    /// </summary>
   public class InformationType
    {/// <summary>
    /// 主键
    /// </summary>
    /// 
    [Key]
        public int Id { get; set; }
        /// <summary>
        /// 资讯类型
        /// </summary>
        public int MessageType { get; set; }
    }
}
