using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 购物表
    /// </summary>
    public class Trade
    {
        [Key]
        public int Id { get; set; }//主键
        public int MasterId { get; set; }//主表Id
        public int Number { get; set; }//数量
        public int UserId { get; set; }//用户ID
    }
}
