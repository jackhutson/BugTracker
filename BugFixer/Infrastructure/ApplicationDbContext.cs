﻿using BugFixer.Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugFixer.Infrastructure {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false) {
        }

        public static ApplicationDbContext Create() {
            return new ApplicationDbContext();
        }
    }
}