using EfCoreSinema.Entites.Concrete;
using EfCoreSinema.EntitesTypeConfigurations.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.EntitesTypeConfigurations.Concrete
{
    public class FilmMap:BaseMap <Film,Guid>
    {
        public override void Configure(EntityTypeBuilder<Film> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.FilmAdi)
                .HasMaxLength(30);

            
        }
    }
}
