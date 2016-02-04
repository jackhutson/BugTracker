using BugFixer.Services.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BugFixer.Infrastructure {
    public class BugRepository : GenericRepository<BugDTO> {

        public BugRepository(DbContext db) : base(db) { }
    }
}