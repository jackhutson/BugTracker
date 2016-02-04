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
        private UserRepository _userRepo;

        public BugService(BugRepository bugRepo, UserRepository userRepo) {
            _bugRepo = bugRepo;
            _userRepo = userRepo;
        }

        public void AddBug(BugDTO dto) {

            var bug = new Bug() {
                Title = dto.Title,
                Description = dto.Description,
                Resolved = dto.Resolved,
                State = dto.State,
                Severity = dto.Severity,
                AssignedUser = _userRepo.FindByUsername(dto.AssignedUser).FirstOrDefault()
            };

            _bugRepo.Add(bug);
            _bugRepo.SaveChanges();
        }
    }
}
