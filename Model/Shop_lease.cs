using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("Shop_lease")]
    public class Shop_lease
    {
        [Key]
        public int Sid			 { get; set; }                      /*--序号*/
        public string Stitle		 { get; set; }                  /*--标题*/
        public int Sheng		 { get; set; }                      /*--地区		*/
        public string Sfloorage	 { get; set; }                      /*--建筑面积*/
        public string SMonthlyRent { get; set; }                    /*--月租*/
        public string SDecoration	 { get; set; }                  /*--装修*/
        public DateTime? SUpdatetime	 { get; set; }              /*--更新时间*/
        public string Stick		 { get; set; }                      /*--置顶*/
        public int States		 { get; set; }                      /*--状态出租还是出售 1代表出售 0代表出租*/
        public int Shop_leaseId { get; set; }           ///商铺出租和出售外键
    }
}
