using Microsoft.EntityFrameworkCore;
using RedisCacheLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisCacheLearning
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Info> Infos { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
