﻿using Bloggy.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggy.Web.Data
{
    public class BloggyDbContext : DbContext
    {
        public BloggyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
