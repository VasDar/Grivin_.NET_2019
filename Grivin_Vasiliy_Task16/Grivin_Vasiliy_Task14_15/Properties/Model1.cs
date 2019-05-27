namespace Grivin_Vasiliy_Task14_15.Properties
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Model1 : DbContext
	{
		public Model1()
			: base("name=UserAndAwards")
		{
		}

		public virtual DbSet<Awards> Awards { get; set; }
		public virtual DbSet<Relations> Relations { get; set; }
		public virtual DbSet<Users> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Awards>()
				.HasMany(e => e.Relations)
				.WithRequired(e => e.Awards)
				.HasForeignKey(e => e.IDAwards);

			modelBuilder.Entity<Users>()
				.HasMany(e => e.Relations)
				.WithRequired(e => e.Users)
				.HasForeignKey(e => e.IDUser);
		}
	}
}
