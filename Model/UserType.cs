using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("UserType")]
    public class UserType                       //用户类型
    {
        [Key]
        public int Tid   { get; set; }
        public string Tname { get; set; }
    }
}
