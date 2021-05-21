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
    [Route("api/Tenement")]
    public class TenementController : Controller
    {
        PropertyBLL _bll;
        public TenementController(PropertyBLL bll)
        {
            _bll = bll;
        }                 
        /// <summary>
        /// 新房
        /// </summary>
        /// <returns></returns>
        /// 
        [Route("New_House"),HttpGet]
        public IActionResult New_House()      
        {
            var list = _bll.Property_manageShow();
            return Ok(new { data = list });
        }

        /// <summary>
        /// 二手房显示
        /// </summary>
        /// <returns></returns>
        [Route("Resold_apartment"),HttpGet]
        public IActionResult Resold_apartment()
        {
            var list = _bll.Resold_apartmentShow();
            return Ok(new { data = list });
        }

        /// <summary>
        /// 租房显示
        /// </summary>
        /// <returns></returns>
        [Route("Renting_room"), HttpGet]
        public IActionResult Renting_room()
        {
            var list = _bll.Resold_apartmentShow();
            return Ok(new { data = list });
        }
    }
}
