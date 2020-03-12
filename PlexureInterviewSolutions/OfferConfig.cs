using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2Solution
{
    public class OfferConfig : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.ToTable("T_Offer");
            builder.HasMany(r => r.Redemptions);
        }
    }
}
