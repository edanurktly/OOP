using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    public enum FaturaTipi
    {
        Alis = 1,
        Satis,
        Iade
    }

    public class FaturaMaster:IFatura
    {
        public Personel Personel { get; set; }
        public Musteri Musteri { get; set; }
        public DateTime KesimTarihi { get; set; }
        public int FaturaNo { get; set; }
        public FaturaTipi FaturaTipi { get; set; }
        public List<FaturaDetay> FaturaDetaylari { get; set; }
    }
}
