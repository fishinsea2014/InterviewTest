using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2Solution
{
    /// <summary>
    /// Utilise EF Core to create the database
    /// Utilise codefirst mode
    /// Utilise FluntAPI 
    /// </summary>
    public class FluentApiContext: DbContext
    {
        public FluentApiContext()
            : base() { }

        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Redemption> Redemptions { get; set; }
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Offer> Offers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(q => q.GetInterface(typeof(IEntityTypeConfiguration<>).FullName) != null);

            foreach (var type in typesToRegister)
            {

                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }

        }
    }
}
