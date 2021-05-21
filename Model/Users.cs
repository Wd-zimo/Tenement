using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("Users")]
    public class Users                          //用户登录
    {
        [Key]
        public int Uid { get; set; }
        public string Uname { get; set; }
        public string Upasswork { get; set; }
    }
}
