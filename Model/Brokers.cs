using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Brokers")]
    public class Brokers                            //--经纪人表 查询   添加  
    {
        [Key]
        public int Bid		 { get; set; }
        public string Bname	 { get; set; }              /*--经纪人的姓名*/
        public string Btel	 { get; set; }              /*--经纪人手机号*/
        public int BserType { get; set; }               /*--经纪人类型*/
        public bool States	 { get; set; }              /*--状态			*/
    }
}
