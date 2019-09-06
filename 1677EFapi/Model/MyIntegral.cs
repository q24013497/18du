using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 我的积分
    /// </summary>
   public  class MyIntegral
   {
        [Key]
        public int Id { get; set; }//主键
        public int Sum { get; set; }//积分总数
        public DateTime Time { get; set; }//时间
        public string Statu { get; set; }//状态
        public int Deal { get; set; }//支出/支入分数
        public int UserId { get; set; }//用户Id

    }
}
