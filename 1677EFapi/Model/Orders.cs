using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class Orders
    {
        [Key]
        public int Id { get; set; }//主键
        public string Name { get; set; }//商品名称
        public int TypeId { get; set; }//商品类型
        public int Number { get; set; }//商品数量
        public int ShopId { get; set; }//商品店铺
        public int Money { get; set; }//金额/积分
        public int Statu { get; set; }//交易状态ID
        public int UserId { get; set; }//用户ID
    }
}
