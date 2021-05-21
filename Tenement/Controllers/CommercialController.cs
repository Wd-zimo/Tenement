using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Model;

namespace Tenement.Controllers
{
    [ApiController]
    [Route("api/Commercial")]
    public class CommercialController : Controller
    {
        CommercialBLL _bll;
        public CommercialController(CommercialBLL bll)
        {
            _bll = bll;
        }

        /// <summary>
        /// 用户管理的显示
        /// </summary>
        /// <returns></returns>
        [Route("Users"),HttpGet]
        public IActionResult Users(string uname="")
        {
            var list = _bll.UsersGLShow();
            if (!string.IsNullOrEmpty(uname))
            {
                list = list.Where(s => s.Uname.Contains(uname)).ToList();
            }
            return Ok(new { data = list });
        }

        /// <summary>
        /// 用户添加
        /// </summary>
        /// <returns></returns>
        [Route("UsersAdd"), HttpPost]
        public IActionResult UsersAdd(UsersGL s)
        {
            var list = _bll.UsersGLAdd(s);
            return Ok(new { data = list,msg=list>0?"添加成功":"添加失败",state=list>0?true:false});
        }

        /// <summary>
        /// 用户修改
        /// </summary>
        /// <returns></returns>
        [Route("UsersUpt"), HttpPost]
        public IActionResult UsersUpt(UsersGL s)
        {
            var list = _bll.UsersGLUpt(s);
            return Ok(new { data = list, msg = list > 0 ? "修改成功" : "修改失败", state = list > 0 ? true : false });
        }

        /// <summary>
        /// 用户修改反填数据
        /// </summary>
        /// <returns></returns>
        [Route("UsersUptId"), HttpGet]
        public IActionResult UsersUptId(int ids)
        {
            var list = _bll.UsersGLID(ids);
            return Ok(new { data = list });
        }



        /// <summary>
        /// 经纪人的显示
        /// </summary>
        /// <returns></returns>
        [Route("Brokers"), HttpGet]
        public IActionResult Brokers(string bname = "")
        {
            var list = _bll.BrokersShow();
            if (!string.IsNullOrEmpty(bname))
            {
                list = list.Where(s => s.Bname.Contains(bname)).ToList();
            }
            return Ok(new { data = list });
        }

        /// <summary>
        /// 经纪人添加
        /// </summary>
        /// <returns></returns>
        [Route("BrokersAdd"), HttpPost]
        public IActionResult BrokersAdd(Brokers s)
        {
            var list = _bll.BrokersAdd(s);
            return Ok(new { data = list, msg = list > 0 ? "添加成功" : "添加失败", state = list > 0 ? true : false });
        }

        /// <summary>
        /// 经纪人修改
        /// </summary>
        /// <returns></returns>
        [Route("BrokersUpt"), HttpPost]
        public IActionResult BrokersUpt(Brokers s)
        {
            var list = _bll.BrokersUpt(s);
            return Ok(new { data = list, msg = list > 0 ? "修改成功" : "修改失败", state = list > 0 ? true : false });
        }

        /// <summary>
        /// 经纪人修改反填数据
        /// </summary>
        /// <returns></returns>
        [Route("BrokersUptId"), HttpGet]
        public IActionResult BrokersUptId(int ids)
        {
            var list = _bll.BrokersID(ids);
            return Ok(new { data = list });
        }
    }
}
