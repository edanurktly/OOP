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
    public class KasaMap:BaseMap<Kasa>
    {
        public override void Configure(EntityTypeBuilder<Kasa> builder)
        {
            
            builder.Property(p=>p.KasaAdi).HasMaxLength(64); //kasa icerisindeki KasaAdi property
            builder.HasIndex(p=>p.KasaAdi).IsUnique();//kasa adindan sadece 1 adet kayit olmasini sagliyoruz
            //burasisi yanlisikla silmeyin baseentity'nin configurayion'i burada yapilir.
            builder.HasData(new Kasa() { Id = 1, KasaAdi = "Tl Kasasi", });
            base.Configure(builder);

        }
    }
}
