using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 用户表
    /// </summary>
   public class UserInfo
    {
        [Key]
        public int Id { get; set; }//主键
        public string Monicker { get; set; }//昵称
        public string Name { get; set; }//真实姓名
        public string Sex { get; set; }//性别
        public int Age { get; set; }//年龄
        public int ImageId { get; set; }//头像
        public int RegionId { get; set; }//地区
        public string Address { get; set; }//详细地址
        public DateTime Balance { get; set; }//余额
        public DateTime Integral { get; set; }//积分
        public string Role { get; set; }//身份
        public string Account { get; set; }//账号
        public string Password { get; set; }//密码
    }
}
