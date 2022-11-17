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
    public class BahisCesitDetayMap:BaseMap<BahisCesitDetay>
    {
        public override void Configure(EntityTypeBuilder<BahisCesitDetay> builder)
        {
            base.Configure(builder);
        }
    }
}
