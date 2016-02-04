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
        private ApplicationUserManager _userRepo;

        public BugService(BugRepository bugRepo, ApplicationUserManager userRepo) {
            _bugRepo = bugRepo;
            _userRepo = userRepo;
        }

        public void AddBug(BugDTO dto, string username) {

            var user = _userRepo.FindByName(username);

            var bug = new Bug() {
                Title = dto.Title,
                Description = dto.Description,
                Resolved = dto.Resolved,
                State = dto.State,
                Severity = dto.Severity,
                AssignedUser = user,
                LinkedBugs = (from l in dto.LinkedBugs
                              select new Bug() {
                                  Title = l.Title,
                                  Description = l.Description,
                                  Resolved = l.Resolved,
                                  State = l.State,
                                  Severity = l.Severity,
                                  AssignedUser = user
                              }).ToList(),
            };

            _bugRepo.Add(bug);
            _bugRepo.SaveChanges();
        }
    }
}
