using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApplication.Models
{
    public class BankCustomerDetails : DbContext
    {
        public BankCustomerDetails(DbContextOptions<BankCustomerDetails> options) : base(options)
        {
        }
            public DbSet<BankCustomer> bankCustomers { get; set; }
        
    }
}
