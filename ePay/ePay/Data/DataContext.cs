using Microsoft.EntityFrameworkCore;

namespace ePay.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts)
        {
        }
    }
}