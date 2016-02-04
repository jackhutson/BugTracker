using BugFixer.Services;
using BugFixer.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BugFixer.Presentation.Controllers
{
    public class UserController : ApiController
    {
        private UserService _userService;

        public UserController(UserService userService) {
            _userService = userService;
        }

        [HttpGet]
        [Route("api/users")]
        public IList<ApplicationUserDTO> GetUser() {
            return _userService.GetUser();
        }
    }
}
