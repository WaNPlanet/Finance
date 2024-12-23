using Microsoft.EntityFrameworkCore;
using finance.Models; // Adjust if `Expense` is in a different namespace.


namespace finance.Models{
    public class FinanceDbContext : DbContext{
        public required DbSet<Expense> Expenses{get; set;}

        public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
        : base(options)
        {
            
        }
    }
}