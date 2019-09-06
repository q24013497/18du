using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 影像活动
    /// </summary>
    public class VideoActivities
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 标题名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 出发地点
        /// </summary>
        public string Becity { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string Linkman { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 活动天数
        /// </summary>
        public int ActivityDays { get; set; }
        /// <summary>
        /// 集合地点
        /// </summary>
        public string Venue { get; set; }
        /// <summary>
        /// 报名截止
        /// </summary>
        public DateTime Deadline { get; set; }
        /// <summary>
        /// 出行日期
        /// </summary>
        public DateTime DepartureDate { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public string Cost { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string Intro { get; set; }
        /// <summary>
        /// 行程详情
        /// </summary>
        public string TravelProfile { get; set; }
        /// <summary>
        /// 总名额
        /// </summary>
        public int Quota { get; set; }
        /// <summary>
        /// 已报名名额
        /// </summary>
        public int RegisteredQuota { get; set; }


    }
}
