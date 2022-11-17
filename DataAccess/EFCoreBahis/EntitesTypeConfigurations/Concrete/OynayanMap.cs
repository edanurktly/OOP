using EFCoreBahis.Entites.Concrete;
using EFCoreBahis.EntitesTypeConfigurations.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBahis.EntitesTypeConfigurations.Concrete
{
  public class OynayanMap:BaseMap<Oynayan>
    {
        public override void Configure(EntityTypeBuilder<Oynayan> builder)
        {
            builder.Property(p => p.TcNo).HasMaxLength(11);
            builder.Property(p => p.AdSoyad).HasMaxLength(38);
            builder.HasIndex(p => p.TcNo).IsUnique();


            builder.HasData(new Oynayan()
            {
                Id = 1,
                AdSoyad = "ali yilmaz", CreateDate = DateTime.Now,
                Bakiye = 1000
            },
           new Oynayan()
             {
                 Id = 2,
                 AdSoyad = "ayse kaya",
                 CreateDate = DateTime.Now,
                 Bakiye = 1000
             },
             new Oynayan()
              {
                  Id = 3,
                  AdSoyad = "Hasan Mert",
                  CreateDate = DateTime.Now,
                  Bakiye = 1000
              },
              new Oynayan()
               {
                   Id = 4,
                   AdSoyad = "Fatma Tasdemir",
                   CreateDate = DateTime.Now,
                   Bakiye = 1000
               }
               );
            base.Configure(builder);
        }
    }
}
