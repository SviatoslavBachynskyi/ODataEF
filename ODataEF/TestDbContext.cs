using Microsoft.EntityFrameworkCore;

namespace ODataEF
{
	public class TestDbContext : DbContext
	{
		public DbSet<TestEntity> TestEntities { get; set; }
		public TestDbContext(DbContextOptions<TestDbContext> options)
			: base(options)
		{ }
	}
}
