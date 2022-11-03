using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_SiparisOtomasyonu.Entities
{
    internal class SiparisMaster
    {
        public DateTime SiparisTarihi { get; set; }
        public string MusteriNo { get; set; }
        public List<SiparisDetay> Detaylar { get; set; }
    }
}
