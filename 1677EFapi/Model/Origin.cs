using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 品牌表
    /// </summary>
    public class Origin
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类别Id
        /// </summary>
        public int TypeId { get; set; }
    }
}
