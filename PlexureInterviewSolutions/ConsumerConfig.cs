using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exercise2Solution
{
    public class ConsumerConfig : IEntityTypeConfiguration<Consumer>
    {
        public void Configure(EntityTypeBuilder<Consumer> builder)
        {
            builder.ToTable("T_Consumers");
            builder.HasAny(r => r.Redemptions);

        }
    }
}
