using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BugFixer.Presentation.Controllers {
    public class BugController : ApiController {
        private BugService _bugService;

        public BugController(BugService _bugService) {
            _bugService = bugService;
        }

        [HttpPost]
        [Route("api/")]
        public void AddBug(int id) {
            return _bugService.AddBug(id);
        }
    }

}