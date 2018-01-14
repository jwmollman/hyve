﻿using System;
using System.Collections.Generic;

namespace HackerNewsClone.Models {
    public class Comment {
        public int ID { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public string Content { get; set; }

        public Post Post { get; set; }

        public List<Comment> Comments { get; set; }
    }
}