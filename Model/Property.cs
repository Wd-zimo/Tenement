using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Property")]
    public class Property           //房源类型
    {
        [Key]
        public int Pid	 { get; set; }
        public string Pname { get; set; }
    }
}
