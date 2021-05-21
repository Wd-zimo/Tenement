using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class FZUserBLL
    {
        SqlDBHelper db;
        public FZUserBLL(SqlDBHelper _db)
        {
            db = _db;
        }

        /// <summary>
        /// 查询显示的方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public virtual List<T> Query<T>()
        {
            string sql = RefiectionComment.ReflectionSelectSql<T>();
            var ds = db.GetData(sql);
            var list = RefiectionComment.DataTableToList<T>(ds.Tables[0]);
            return list;
        }

        /// <summary>
        /// 添加方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="s"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual int SqlAdd<T>(T t)
        {
            string sql = RefiectionComment.ReflectionInsertSql<T>(t);
            return db.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ids"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual int SqlDel<T>(string ids)
        {

            string sql = RefiectionComment.ReflectionDeleteSql<T>(ids);
            return db.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual int SqlUpt<T>(T t)
        {
            string sql = RefiectionComment.ReflectionUptSql<T>(t);
            return db.ExecuteNonQuery(sql);
        }


    }
}
