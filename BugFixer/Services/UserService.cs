using BugFixer.Infrastructure;
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


        public IList<UserRepository> GetUserList() {

        }
    }
}