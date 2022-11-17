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
    public class KasaHareketMap:BaseMap<KasaHareket>
    {
        public override void Configure(EntityTypeBuilder<KasaHareket> builder)
        {
           
            base.Configure(builder);
        }
    }
}
