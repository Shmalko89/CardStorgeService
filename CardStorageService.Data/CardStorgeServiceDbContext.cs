using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardStorageService.Data
{
    public class CardStorgeServiceDbContext : DbContext
    {
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Card> Cards { get; set; }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountSession> AccountSessions { get; set; }


        public CardStorgeServiceDbContext(DbContextOptions options) : base(options) { }   
    }
}
