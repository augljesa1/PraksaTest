using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TestAnes.dal.Domain;

namespace TestAnes.dal.Configuration
{
    public abstract class BaseEntitityConfiguration<TEntitity> : IEntityTypeConfiguration<TEntitity> where TEntitity : BaseEntitity
    {
        public virtual void Configure(EntityTypeBuilder<TEntitity> builder)
        {
            builder.HasKey(p => p.Id);

        }
    }
}
