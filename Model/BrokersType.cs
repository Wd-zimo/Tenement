using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("BrokersType")]
    public class BrokersType                        //经纪人类型表
    {
        [Key]
        public int Bid   { get; set; }
        public string Bname { get; set; }
    }
}
