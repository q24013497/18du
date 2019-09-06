using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{/// <summary>
/// 商品表
/// </summary>
    public class Shop
    {/// <summary>
    /// 主键
    /// </summary>
[Key]
        public int Id { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 店铺介绍
        /// </summary>
        public string Introducation { get; set; }
        /// <summary>
        /// 法人
        /// </summary>
        public string Corporate { get; set; }
        /// <summary>
        /// 法人身份证
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 银行账号
        /// </summary>
        public string BankAccount { get; set; }
    }
}
