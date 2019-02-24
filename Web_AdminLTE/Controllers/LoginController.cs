using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fonour.Application.UserApp;
using Microsoft.AspNetCore.Mvc;

namespace Web_AdminLTE.Controllers
{
    public class LoginController : Controller
    {
        private IUserAppService _userAppService;
        public LoginController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var user = _userAppService.CheckUser("admin", "123456");
            return View();
        }
    }
}