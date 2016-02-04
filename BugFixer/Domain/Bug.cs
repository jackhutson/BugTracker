using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugFixer.Domain {
    public class Bug : IDbEntity, IActivatable{
        public enum Status {
            Reported,
            Investigating,
            InProgress,
            Resolved,
            Deleted
        }

        public enum Priority {
            Critical,
            High,
            Medium,
            Low
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Resolved { get; set; }
        public Status State { get; set; }
        public Priority Severity { get; set; }
        
        public ApplicationUser AssignedUser { get; set; }
        public IList<Bug> LinkedBugs { get; set; }


        public bool Active {
            get {
                return State < Status.Resolved;
            }
            set {
                if (!value) {
                    State = Status.Deleted;
                }
            }
        }
    }
}