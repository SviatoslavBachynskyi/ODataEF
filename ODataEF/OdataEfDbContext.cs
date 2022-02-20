using Microsoft.EntityFrameworkCore;
using ODataEF.Entities;

namespace ODataEF
{
	public class OdataEfDbContext : DbContext
	{
		public DbSet<GroupEntity> Groups { get; set; }

		public DbSet<StudentEntity> Students { get; set; }

		public OdataEfDbContext(DbContextOptions<OdataEfDbContext> options)
			: base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<StudentEntity>()
				.HasOne(e => e.Group)
				.WithMany(g => g.Students)
				.HasForeignKey(s => s.GroupId)
				.IsRequired();
		}
	}
}
