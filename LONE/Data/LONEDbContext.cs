using LONE.Models.Domain; //for Requests
using Microsoft.EntityFrameworkCore;

namespace LONE.Data
{
    public class LONEDbContext : DbContext //DbContext base class comes from EF core
    {
        public LONEDbContext(DbContextOptions options) : base(options) //constructor with options param to pass back to base class
        {
        }
        // properties for EF to create for LONE Db i.e. to create a model 
        public DbSet<Request> Requests { get; set; }  //Requests property = the table name in LONE Db created by EF migration
    }
}
