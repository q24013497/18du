using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 收藏表
    /// </summary>
    public class Collect
    {
        [Key]
        public int Id { get; set; }//主键
        public int MasterId { get; set; }//主表Id
        public int UserId { get; set; }//用户ID

    }
}
