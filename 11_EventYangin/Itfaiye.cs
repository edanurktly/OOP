namespace _11_EventYangin
{
    internal class Itfaiye
    {
        public Itfaiye()
        {
        }
        public void MudahaleEt(object yardimCagiran)
        {
            if(yardimCagiran is Alarm)
            {
                Console.WriteLine("Itfaiye yangina mudahale etti.");
            }
        }
    }
}