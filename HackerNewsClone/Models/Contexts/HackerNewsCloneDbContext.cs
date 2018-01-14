﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HackerNewsClone.Models.Contexts {
    public class HackerNewsCloneDbContext : DbContext {
        public HackerNewsCloneDbContext() : base("HackerNewsCloneDbContextConnection") {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}