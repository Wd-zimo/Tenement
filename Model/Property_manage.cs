using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Property_manage")]
    public class Property_manage            //房源管理
    {
        [Key]
        public int Nid { get; set; }
        public int PropertyId { get; set; }         //房源类型外键
        public int tb_districtId { get; set; }        //省市区外键
        public int CommunityId { get; set; }            //小区外键
        public DateTime? OpeningTimes { get; set; }
        public string Title { get; set; }
        public string Developers { get; set; }
        public string Propertyfirm { get; set; }
        public string Propertyyear { get; set; }
        public string Label { get; set; }
        public string Region { get; set; }
        public string Floorage { get; set; }
        public string Mittelkurs { get; set; }
        public string Discounts { get; set; }
        public string Loupanyh { get; set; }
        public bool States { get; set; }
        public string Unit { get; set; }
        public int Sums { get; set; }
        public string Decoration { get; set; }
        public DateTime? Updatetime { get; set; }
        public string Stick { get; set; }
        public int FMonthlyRent { get; set; }
        public bool StateChu { get; set; }
    }
}
