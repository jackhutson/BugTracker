using BugFixer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugFixer.Services.Models {
    public class BugDTO {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Resolved { get; set; }
        public Bug.Status State { get; set; }
        public Bug.Priority Severity { get; set; }
        public string AssignedUser { get; set; }
        public IList<BugDTO> LinkedBugs { get; set; }
    }
}