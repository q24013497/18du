using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 器材租贫
    /// </summary>
    public class EquipmentRentals
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 押金
        /// </summary>
        public int CashPledge { get; set; }

        /// <summary>
        /// 租用费
        /// </summary>
        public int RentalCharges { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 租用联系人
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 租用联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 其他信息
        /// </summary>
        public string OtherInformation { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Images { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public string Particulars { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        
    }
}
