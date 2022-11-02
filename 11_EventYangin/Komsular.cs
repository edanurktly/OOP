namespace _11_EventYangin
{
    internal class Komsular
    {
        public Komsular()
        {
        }
        public void RahatsizOl(object rahatsizEden)
        {
            if(rahatsizEden is Alarm)
            {
                Console.WriteLine("komşular rahatsiz oldu");
            }
        }
    }
}