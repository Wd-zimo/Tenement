using Model;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        SqlDBHelper _db;
        public LoginBLL(SqlDBHelper db)
        {
            _db = db;
        }
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public Administrator AdministratorLogin(string aname="",string passwork="")
        {
            string sql = $"select * from Administrator where Aname='{aname}' and Apasswork='{passwork}'";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Administrator>(da.Tables[0]);
            return list[0];
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public Users UserLogin(string uname = "", string passwork = "")
        {
            string sql = $"select * from Users where uname='{uname}' and Upasswork='{passwork}'";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Users>(da.Tables[0]);
            return list[0];
        }

        /// <summary>
        /// 商户登录
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public Commodity CommodityLogin(string Cname = "", string passwork = "")
        {
            string sql = $"select * from Commodity where Cname='{Cname}' and Cpasswork='{passwork}'";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Commodity>(da.Tables[0]);
            return list[0];
        }
    }
}
