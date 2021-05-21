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
    public class LeaseController : Controller
    {
        LeaseBLL _bll;
        public LeaseController(LeaseBLL bll)
        {
            _bll = bll;
        }
        /// <summary>
        /// 写字楼出租
        /// </summary>
        /// <returns></returns>
        /// 
        [Route("Offices_lease"),HttpGet]
        public IActionResult Offices_lease()
        {
            var list = _bll.Offices_lease();
            return Ok(new { data = list });
        }
    }
}
