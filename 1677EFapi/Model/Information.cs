using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 资讯表
    /// </summary>
    public class Information
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 资讯名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 资讯介绍
        /// </summary>
        public string Informationintroduced { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public float Price { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 详情介绍Id
        /// </summary>
        public int DetailId { get; set; }

        public string Content { get; set; }
    }
}
