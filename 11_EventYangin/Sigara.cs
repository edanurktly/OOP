using static _11_EventYangin.Program;

namespace _11_EventYangin
{
    internal class Sigara
    {
        public event EventTip Yandim;

        public void Icil()
        {
            Console.WriteLine("Sigara yandi");
            Yandim(this);
        }
    }
}