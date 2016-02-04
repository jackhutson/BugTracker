using BugFixer.Domain;
using BugFixer.Infrastructure;
using BugFixer.Services.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugFixer.Services {
    public class BugService {

        private BugRepository _bugRepo;

        public BugService(BugRepository bugRepo) {
            _bugRepo = bugRepo;
        }

        public void AddBug(BugDTO dto) {

            var bug = new Bug() {
                Title = dto.Title,
                Description = dto.Description,
                Resolved = dto.Resolved,
                State = dto.State,
                Severity = dto.Severity,
                //AssignedUser = from u in 
            };

            _bugRepo.Add(bug);
            _bugRepo.SaveChanges();
        }
    }
}
