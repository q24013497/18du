using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 物品样式表
    /// </summary>
    public class Style
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 物品样式名称
        /// </summary>

        public string Name { get; set; }

        /// <summary>
        /// Pid
        /// </summary>
        public int Pid { get; set; }
    }
}
