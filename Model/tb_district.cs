using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("tb_district")]
    public class tb_district             //省市区表
    {
        [Key]
        public int id { get; set; }
        public int pid { get; set; }
        public string district { get; set; }
        public int level { get; set; }
    }
}
