using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 图片表
    /// </summary>
    public class Images
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 主数据Id
        /// </summary>
        public int MasterId { get; set; }
    }
}
