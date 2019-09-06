using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 详细资讯表
    /// </summary>
    public class DetailInformation
    {/// <summary>
    /// 主键
    /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 咨询表Id
        /// </summary>
        public int InformationId { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 详细资讯介绍
        /// </summary>
        public int Introduction { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string Linkman { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
    }
}
