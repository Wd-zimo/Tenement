using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Officestype")]
    public class Officestype            //写字楼类型
    {
        [Key]
        public int Oid	 { get; set; }
        public string Oname { get; set; }
    }
}
