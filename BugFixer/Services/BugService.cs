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
        private ApplicationUserManager _userRepo;

        public BugService(BugRepository bugRepo, ApplicationUserManager userRepo) {
            _bugRepo = bugRepo;
            _userRepo = userRepo;
        }

        public IList<BugDTO> AddBug(BugDTO dto, string username) {

            var user = _userRepo.FindByName(username);

            var bug = new Bug() {
                Title = dto.Title,
                User = user,
                LinkedBugs = (from l in dto.LinkedBugs
                             select l).ToList(),
                Description = dto.Description,
                Severity = dto.Severity,
                State = dto.State
            };

            _bugRepo.Add(bug);
            _bugRepo.SaveChanges();

            return new BugDTO() {
                Title = bug.Title,
                User = bug.User,
                LinkedBugs = bug.LinkedBugs,
                Description = bug.Description,
                Severity = bug.Severity,
                State = bug.State
            };
        }
    }
}