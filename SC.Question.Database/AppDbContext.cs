using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SC.Question.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Question.Database
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<TestType> TestTypes { get; set; }
        public DbSet<TestSubject> TestSubjects { get; set; }
        public int MyProperty { get; set; }
    }
}
