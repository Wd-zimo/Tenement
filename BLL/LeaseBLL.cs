using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class LeaseBLL
    {
        SqlDBHelper _db;
        public LeaseBLL(SqlDBHelper db)
        {
            _db = db;
        }

        /// <summary>
        /// 写字楼类型
        /// </summary>
        /// <returns></returns>
        public List<Officestype> Offices_Type()
        {

            string sql = "select * from Officestype";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Officestype>(da.Tables[0]);
            return list;
        }

        /// <summary>
        /// 写字楼和出售
        /// </summary>
        /// <returns></returns>
        public List<Offices_lease> Offices_Show()
        {

            string sql = "select * from Offices_lease a left join Officestype b on a.OfficestypeId=b.Oid left join Images c on a.Oid=c.Offices_leaseId where States=1";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Offices_lease>(da.Tables[0]);
            return list;
        }

        /// <summary>
        /// 写字楼和出租
        /// </summary>
        /// <returns></returns>
        public List<Offices_lease> Offices_lease()
        {

            string sql = "select * from Offices_lease a left join Officestype b on a.OfficestypeId=b.Oid left join Images c on a.Oid=c.Offices_leaseId where States=0";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Offices_lease>(da.Tables[0]);
            return list;
        }










        /// <summary>
        /// 商铺的出售
        /// </summary>
        /// <returns></returns>
        public List<Shop_lease> Shop_Show()
        {

            string sql = "select * from Shop_lease a left join Images b on a.sid=b.Shop_leaseId where States=1";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Shop_lease>(da.Tables[0]);
            return list;
        }
        /// <summary>
        /// 商铺的出租
        /// </summary>
        /// <returns></returns>
        public List<Shop_lease> Shop_lease()
        {

            string sql = "select * from Shop_lease a left join Images b on a.sid=b.Shop_leaseId where States=0";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Shop_lease>(da.Tables[0]);
            return list;
        }
    }
}
