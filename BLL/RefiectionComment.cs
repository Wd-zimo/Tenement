using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BLL
{
    public  class RefiectionComment     //封装的一个公共类
    {
        /// <summary>
        ///反射显示查询的方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string ReflectionSelectSql<T>()
        {
            string tablename = GetTableAttriblerName<T>();     //表名

            string values = "";        //字段名
            System.Type t = typeof(T);
            var pinfos = t.GetProperties();   //通过反射寻找名字
            foreach (var item in pinfos)
            {
                values += $"{""+item.Name+","}";
            }
            return $"select {values.TrimEnd(',')} from {tablename}";
        }

        /// <summary>
        /// 反射删除方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ids"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string ReflectionDeleteSql<T>(string ids, string key = "id")
        {
            var _tablename = GetTableAttriblerName<T>();
            return $"delete from {_tablename} where {key} in ({ids})";
        }

        /// <summary>
        /// 反射添加方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string ReflectionInsertSql<T>(T t, string key="id")
        {
            string _tablename = "", _files = "", _values = "";
            _tablename = GetTableAttriblerName<T>();     //表名
            System.Type _t = typeof(T);                     //获取Model里面的类型
            var pinfos = _t.GetProperties();              //通过反射获取属性
            foreach (var item in pinfos)
            {
                var _f = item.Name;
                object _v = item.GetValue(t);

                if (_v != null)
                {
                    //主键自增或者有默认值
                    if (!_f.ToLower().Equals(key.ToLower()))
                    {
                        _values += $"'{_v}',";
                        _files += $"{_f},";
                    }
                }
            }
            return $"insert into {_tablename} ({_files.TrimEnd(',')}) values ({_values.TrimEnd(',')})";
        }

        /// <summary>
        /// 反射修改更新方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string ReflectionUptSql<T>(T t, string key = "id")
        {

            string _tablename = GetTableAttriblerName<T>(), _fields = "", _id = "";
            System.Type _t = typeof(T);
            var pinfos = _t.GetProperties();
            foreach (var item in pinfos)
            {
                var _v = item.Name;
                object _f = item.GetValue(t);
                //判断值不为null的，才可以拼接
                if (!_v.ToLower().Equals(key.ToLower()))
                {
                    _fields += $"{_v}='{_f}',";
                }
                else
                {
                    _id = _f.ToString();
                }
            }

            return $"Update {_tablename} set {_fields.TrimEnd(',')} where id='{_id}'";

        }

        /// <summary>
        /// 封装的表名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string GetTableAttriblerName<T>()
        {
            string _tableName = "";
            MemberInfo info = typeof(T);
            var tas = (TableAttribute)info.GetCustomAttribute(typeof(TableAttribute), false);

            if (tas != null)
                _tableName = tas.Name;

            return _tableName;
        }

        /// <summary>
        /// 数据表转List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<T> DataTableToList<T>(DataTable dt)
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
