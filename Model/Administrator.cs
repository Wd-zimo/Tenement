using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("Administrator")]
    public class Administrator                  //管理员登录
    {
        [Key]
        public int Aid		  { get; set; }
        public string Aname	 { get; set; }
        public string Apasswork { get; set; }
    }
}
