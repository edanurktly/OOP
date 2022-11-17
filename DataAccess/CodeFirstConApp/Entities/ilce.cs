namespace CodeFirstConApp.Entities
{
    public class ilce
    {
        public int  Id { get; set; }
        public string IlceAdi { get; set; }
        public int SehirId { get; set; }
        public Sehir Sehir { get; set; }
    }
}