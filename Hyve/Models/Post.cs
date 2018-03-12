﻿using System;
using System.Collections.Generic;

namespace Hyve.Models {
    public class Post {
        public int Id { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string Title { get; set; }

        public string ExternalLink { get; set; }

        public string Content { get; set; }

        public User CreatedBy { get; set; }

        public PostType PostType { get; set; }

        public bool Enabled { get; set; }

        public IList<Comment> Comments { get; set; }
    }
}