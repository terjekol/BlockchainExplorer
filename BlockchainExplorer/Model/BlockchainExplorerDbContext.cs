using Microsoft.EntityFrameworkCore;

namespace BlockchainExplorer.Model
{
    public class BlockchainExplorerDbContext : DbContext
    {
        public BlockchainExplorerDbContext(DbContextOptions<BlockchainExplorerDbContext> options)
            : base(options)
        {
        }
        public DbSet<Search> Search { get; set; }
    }
}
