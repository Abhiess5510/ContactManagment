using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagement.Models
{
    public class ContactDetailsDBContext : DbContext
    {
        public ContactDetailsDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ContactDetails> Contacts { get; set; }

    }
}
