using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class CommercialBLL
    {
        SqlDBHelper _db;
        public CommercialBLL(SqlDBHelper db)
        {
            _db = db;
        }

        /// <summary>
        /// 用户类型
        /// </summary>
        /// <returns></returns>
        public  List<UserType> UserTypeShow()
        {
            string sql = "select * from UserType";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<UserType>(da.Tables[0]);
            return list;
        }

        /// <summary>
        /// 用户管理
        /// </summary>
        /// <returns></returns>
        public List<UsersGL> UsersGLShow()
        {
            string sql = "select * from UsersGL a left join UserType b on a.UserTypeId=b.Tid";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<UsersGL>(da.Tables[0]);
            return list;
        }

        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int UsersGLAdd(UsersGL s)
        {
            string sql = $"insert into UsersGL values ('{s.Uname}','{s.Utel}','{s.UserTypeId}','{s.States}')";
            return _db.ExecuteNonQuery(sql);

        }

        /// <summary>
        /// 用户修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>z
        public int UsersGLUpt(UsersGL s)
        {
            string sql = $"update  UsersGL set Uname='{s.Uname}',Utel='{s.Utel}',UserTypeId='{s.UserTypeId}',States='{s.States}' where Uid={s.Uid}";
            return _db.ExecuteNonQuery(sql);

        }

        /// <summary>
        /// 用户反填
        /// </summary>
        /// <returns></returns>
        public UsersGL UsersGLID(int ids)
        {
            string sql = $"select * from UsersGL a left join UserType b on a.UserTypeId=b.Tid where a.Uid={ids}";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<UsersGL>(da.Tables[0]);
            return list[0];
        }



        /// <summary>
        /// 经纪人类型
        /// </summary>
        /// <returns></returns>
        public List<BrokersType> BrokersType()
        {
            string sql = "select * from BrokersType";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<BrokersType>(da.Tables[0]);
            return list;
        }

        /// <summary>
        /// 经纪人管理
        /// </summary>
        /// <returns></returns>
        public List<Brokers> BrokersShow()
        {
            string sql = "select * from Brokers a left join BrokersType b on a.BserType=b.Bid";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Brokers>(da.Tables[0]);
            return list;
        }

        /// <summary>
        /// 经纪人删除
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int BrokersAdd(string ids)
        {
            string sql = $"delete from Brokers where Bid in ('{ids}')";
            return _db.ExecuteNonQuery(sql);

        }

        /// <summary>
        /// 经纪人添加
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int BrokersAdd(Brokers s)
        {
            string sql = $"insert into Brokers values ('{s.Bname}','{s.Btel}','{s.BserType}','{s.States}')";
            return _db.ExecuteNonQuery(sql);

        }

        /// <summary>
        /// 经纪人修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>z
        public int BrokersUpt(Brokers s)
        {
            string sql = $"update  Brokers set Bname='{s.Bname}',Btel='{s.Btel}',BserType='{s.BserType}',States='{s.States}' where Bid={s.Bid}";
            return _db.ExecuteNonQuery(sql);

        }

        /// <summary>
        /// 经纪人反填
        /// </summary>
        /// <returns></returns>
        public Brokers BrokersID(int ids)
        {
            string sql = $"select * from Brokers a left join BrokersType b on a.BserType=b.Bid where a.Bid={ids}";
            var da = _db.GetData(sql);
            var list = _db.DataTableToList<Brokers>(da.Tables[0]);
            return list[0];
        }

    }
}
