using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2Solution
{
    public class CouponConfig : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.ToTable("T_Coupon");
            builder.HasMany(r => r.Redemptions);
        }
    }
}
