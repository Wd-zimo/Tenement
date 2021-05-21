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
    [Route("api/Login")]
    public class LoginController : Controller
    {

        LoginBLL _bll;
        public LoginController(LoginBLL bll)
        {
            _bll = bll;
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [Route("Administrator"),HttpPost]
        public IActionResult Administrator(string aname = "", string passwork = "")
        {
            var list = _bll.AdministratorLogin(aname,passwork);
            return Ok(new { data = list });
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [Route("UserLogin"), HttpPost]
        public IActionResult UserLogin(string uname = "", string passwork = "")
        {
            var list = _bll.UserLogin(uname, passwork);
            return Ok(new { data = list });
        }

        /// <summary>
        /// 商户登录
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [Route("Commodity"), HttpPost]
        public IActionResult Commodity(string Cname = "", string passwork = "")
        {
            var list = _bll.CommodityLogin(Cname, passwork);
            return Ok(new { data = list });
        }
    }
}
