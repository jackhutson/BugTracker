using BugFixer.Infrastructure;
using BugFixer.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugFixer.Services {
    public class UserService {
        private UserRepository _userRepo;

        public UserService(UserRepository userRepo) {
            _userRepo = userRepo;
        }


        public IList<ApplicationUserDTO> GetUser() {
            return (from u in _userRepo.FindUser()
                    select new ApplicationUserDTO() {
                        UserName = u.UserName

                    }).ToList();

        }
    }
}