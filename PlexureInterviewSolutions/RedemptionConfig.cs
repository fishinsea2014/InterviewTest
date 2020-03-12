using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2Solution
{
    public class RedemptionConfig: IEntityTypeConfiguration<Redemption>
    {
        public void Configure(EntityTypeBuilder<Redemption> builder)
        {
            builder.ToTable("T_Redemption");
        }
    }
}
