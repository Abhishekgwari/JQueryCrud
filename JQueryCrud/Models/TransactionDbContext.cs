using Microsoft.EntityFrameworkCore;

namespace JQueryCrud.Models
{
    public class TransactionDbContext :DbContext

    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options):base(options) 
        {
            
        }

    public DbSet<TransactionModel> Transactions { get; set; }
    }
}
