using System;
using Microsoft.EntityFrameworkCore;

namespace Final4360 // You can use any namespace you like. Remember to add the using directive to Program.cs
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
			: base(options)
		{
		}
        public DbSet<resident> resident {get; set;}=null!;
        public DbSet<package> package {get; set;}=null!;
        public DbSet<posting> posting {get; set;}=null!;
        public DbSet<staff> staff {get; set;}=null!;
        public DbSet<unknown> unknown {get; set;}=null!;
    }
}