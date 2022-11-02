namespace _11_EventYangin
{
    internal class Insanlar
    {
        public string Ad { get; private set; }
        public Insanlar(string ad)
        {
            Ad= ad;
        }
        public void RahatsizOl(object rahatsizEden)
        {
            if (rahatsizEden is Alarm)
            {
                Console.WriteLine($"{Ad} alarmdan dolayı rahatsiz oldu");
            }
            else if (rahatsizEden is Kablo)
            {
                Console.WriteLine($"{Ad} kablodan dolayi rahatsiz oldu");
            }
            else if (rahatsizEden is Sigara)
            {
                Console.WriteLine($"{Ad} sigaradan dolayi rahatsiz oldu");
            }
        }
            public void Kac(object sorun)
            {
                if (sorun is Alarm)
                {

                    Console.WriteLine($"{Ad} alarmdan dolayi kacti");
                }
                else if (sorun is Kablo)
                {
                    Console.WriteLine($"{Ad} kablodan dolayi kacti");

                }
                else if (sorun is Sigara)
                {
                    Console.WriteLine($"{Ad} sigaradan dolayi kacti");

                }

            }
        }
    }
