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
    public class BugController : ApiController
    {
        private BugService _bugService;

        public BugController(BugService bugService) {
            _bugService = bugService;
        }

        [Route("api/bug")]
        [HttpPost]
        public void AddBug(BugDTO newBug) {
            _bugService.AddBug(newBug);
        }

        [HttpGet]
        [Route("api/bug")]
        public IList<BugDTO> GetBugs() {
            return _bugService.GetBugs();
        }
    }
}
