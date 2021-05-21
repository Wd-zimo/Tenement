using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Linq;

namespace DAL
{
    public class SqlDBHelper
    {
        IConfiguration _config;
        public SqlDBHelper(IConfiguration config)
        {
            _config = config;
        }
        public string connstr { get { return _config.GetConnectionString("sqlconnstr");} set { } }

        /// <summary>
        /// 返回数据集合
        /// 查询、显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public  DataSet GetData(string sql)
        {
            using(SqlConnection conn=new SqlConnection(connstr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            using(SqlConnection conn=new SqlConnection(connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
        }

        /// <summary>
        /// 数据表转List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public  List<T> DataTableToList<T>(DataTable dt)
        {

            Type t = typeof(T);//获取类型
            //获取所有属性
            PropertyInfo[] p = t.GetProperties();
            //定义集合
            List<T> list = new List<T>();
            //遍历数据表
            foreach (DataRow dr in dt.Rows)
            {
                //创建对象
                T obj = (T)Activator.CreateInstance(t);
                //数据流列数
                string[] sdrFileName = new string[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sdrFileName[i] = dt.Columns[i].ColumnName.ToLower();
                }
                foreach (PropertyInfo item in p)
                {
                    //判断Model中的属性是否在流的列名中
                    if (sdrFileName.ToList().IndexOf(item.Name.ToLower()) > -1)
                    {
                        if (dr[item.Name] != System.DBNull.Value)
                        {
                            item.SetValue(obj, dr[item.Name]);//对象属性赋值
                        }
                        else
                        {
                            item.SetValue(obj, null);//对象属性赋值
                        }
                    }
                    else
                    {
                        item.SetValue(obj, null);//对象属性赋值
                    }

                }
                list.Add(obj);
            }
            return list;
        }

    }
}
