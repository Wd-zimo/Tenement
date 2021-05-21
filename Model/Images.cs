using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Images")]
    public class Images                     //房源图片
    {
        [Key]
        public int Mid { get; set; }
        public string Mimg { get; set; }
        public int New_HouseId { get; set; }            //房源表
        public int CommunityId { get; set; }            //小区外键
        public int Offices_leaseId { get; set; }          //-写字楼出租和出售
        public int Shop_leaseId { get; set; }           ///商铺出租和出售外键

    }
}
