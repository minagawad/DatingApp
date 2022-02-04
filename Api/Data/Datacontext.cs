using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
namespace Api.Data
{
    public class Datacontext:DbContext
    {

        public Datacontext(DbContextOptions options):base(options)
        {

        }
        public DbSet<AppUser> appUsers { get; set; }
    }
}
