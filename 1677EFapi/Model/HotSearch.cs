using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 热门搜索
    /// </summary>
   public class HotSearch
    {/// <summary>
    /// 主键啊
    /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public int Name { get; set; }
        /// <summary>
        /// 类别Id
        /// </summary>
        public int TypeId { get; set; }
    }
}
