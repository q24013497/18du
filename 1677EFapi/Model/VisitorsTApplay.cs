using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Model
{
    /// <summary>
    /// 游客报名
    /// </summary>
   public class VisitorsTApplay
    {
        [Key]
        public int Id { get; set; }//主键
        public string Name { get; set; }//景点名称
        public string Message { get; set; }//景点信息
        public int UserId { get; set; }//用户Id
        public int Money { get; set; }//金额/积分
        public int StatusId { get; set; }//交易状态Id
    }
}
