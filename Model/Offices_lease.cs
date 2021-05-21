using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Offices_lease")]
    public class Offices_lease              //写字楼出租和出售/商铺出租和出售
    {   
        [Key]
        public int Oid { get; set; }                            /*--序号*/
        public string title { get; set; }                       /*--标题*/
        public int Sheng { get; set; }                          /*--地区		*/
        public string floorage { get; set; }                    /*--建筑面积*/
        public string MonthlyRent { get; set; }                 /*--月租*/
        public string Csum { get; set; }                        /*--总价*/
        public string Decoration { get; set; }                  /*--装修*/
        public int OfficestypeId { get; set; }                  /*--外键写字楼类型*/
        public DateTime? Updatetime { get; set; }               /*--更新时间*/
        public string stick { get; set; }                       /*--置顶*/
        public int States { get; set; }                         /*--状态出租还是出售 1代表出售 0代表出租*/
        public int Offices_leaseId { get; set; }          //-写字楼出租和出售
    }
}
