using AR.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace AR.Data
{
    //entityFramework Version = 5.8(Remember this)
    public class MainContest : DbContext
    {
        public MainContest(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Client> Client { get; set; }
    }
}
