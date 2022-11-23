using EfCoreSinema.Entites.Concrete;
using EfCoreSinema.EntitesTypeConfigurations.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.EntitesTypeConfigurations.Concrete
{
    public class GosterimMap: BaseMap<Gosterim, Guid>
    {
        public override void Configure(EntityTypeBuilder<Gosterim> builder)
        {
            base.Configure(builder);

            
        }
    }
}
