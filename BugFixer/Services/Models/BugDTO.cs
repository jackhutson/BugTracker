using BugFixer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugFixer.Services.Models {
    public class BugDTO {
        public string Title { get; set; }
        public ApplicationUserDTO User { get; set; }
        public IList<BugDTO> LinkedBugs { get; set; }
        public string Description { get; set; }
        public Priority Severity { get; set; }
        public Status State { get; set; }

    }
}