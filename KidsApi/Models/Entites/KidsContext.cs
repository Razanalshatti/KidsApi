﻿using Microsoft.EntityFrameworkCore;

namespace KidsApi.Models.Entites
{
    public class KidsContext : DbContext
    {
        public DbSet<Parent> Parent { get; set; }

        public KidsContext(DbContextOptions<KidsContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        //public static UserAEntity Create(string username, string password, bool isAdmin)
        //{
        //    return new UserAEntity
        //    {
        //        Username = username,
        //        Password = BCrypt.Net.BCrypt.EnhancedHashPassword(password),
        //        IsAdmin = isAdmin,
        //    };
        //}
    }

  
}