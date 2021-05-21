using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
    public class PropertyBLL
    {
        SqlDBHelper _db;
        public PropertyBLL(SqlDBHelper db)
        {
            _db = db;
        }
        /// <summary>
        /// 新房显示
        /// </summary>
        /// <returns></returns>
        public List<Property_manage> Property_manageShow()
        {
            string sql = "select * from Property_manage a left join Images b on a.Nid=b.New_HouseId left join Property c on a.PropertyId=c.Pid left join [tb_district] d on  a.tb_districtId=d.id left join Community e on a.CommunityId=e.Cid  where a.PropertyId=1";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Property_manage>(da.Tables[0]);
            return list;
        }

        /// <summary>
        /// 二手房显示
        /// </summary>
        /// <returns></returns>
        public List<Property_manage> Resold_apartmentShow()
        {
            string sql = "select * from Property_manage a left join Images b on a.Nid=b.New_HouseId left join Property c on a.PropertyId=c.Pid left join [tb_district] d on  a.tb_districtId=d.id left join Community e on a.CommunityId=e.Cid  where a.PropertyId=2";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Property_manage>(da.Tables[0]);
            return list;
        }

        /// <summary>
        /// 出租房显示
        /// </summary>
        /// <returns></returns>
        public List<Property_manage> Rental_housingShow()
        {
            string sql = "select * from Property_manage a left join Images b on a.Nid=b.New_HouseId left join Property c on a.PropertyId=c.Pid left join [tb_district] d on  a.tb_districtId=d.id left join Community e on a.CommunityId=e.Cid  where a.PropertyId=3";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Property_manage>(da.Tables[0]);
            return list;
        }
    }
}
