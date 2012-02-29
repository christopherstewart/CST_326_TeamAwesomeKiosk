using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AwesomeKiosk.Models
{
    public class AppServerEntities : DbContext
    {
        public DbSet<Job> Job_DbSet;
        public DbSet<QuestionSet> QuestionSet_DbSet;
        public DbSet<Question> Question_DbSet;
        public DbSet<Answer> Answer_DbSet;
        public DbSet<Location> Location_DbSet;
        public DbSet<Store> Stores_DbSet;
        public DbSet<JobListing> JobListing_DbSet;
        public DbSet<CompletedApp> CompletedApps_DbSet;
        public DbSet<Login> Login_DbSet;
    }
}
