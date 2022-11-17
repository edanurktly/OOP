using EfCoreKitaplık.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplık.EntitesTypeConfigurations.Abstract
{
    public abstract class BaseMap<T, Key> : IEntityTypeConfiguration<T> where T : BaseEntity<Key>
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CreateDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("GetDate()");

            builder.Property(p => p.UpdateDate).HasColumnType("datetime");

            builder.Property(p => p.DeleteDate).HasColumnType("datetime");
        }
    }
}
