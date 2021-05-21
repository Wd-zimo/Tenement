using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("UsersGL")]
    public class UsersGL                //用户管理表
    {
        [Key]
        public int Uid        { get; set; }
        public string Uname		 { get; set; }
        public string Utel		 { get; set; }
        public int UserTypeId   { get; set; }
        public bool States		 { get; set; }
        public string Tname { get; set; }
    }
}
