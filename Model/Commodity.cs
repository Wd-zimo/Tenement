using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Commodity")]
    public class Commodity                              //商品登录
    {
        [Key]
        public int Cid		  { get; set; }
        public string Cname	 { get; set; }
        public string Cpasswork { get; set; }
    }
}
