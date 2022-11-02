using static _11_EventYangin.Program;

namespace _11_EventYangin
{
    internal class Alarm
    {
        public event EventTip AlarmCaldi;
        
        public Alarm()
        {
        }

        public void AlarmCal(object alarmitetikleyen)
        {
            if(alarmitetikleyen is Kablo)
            {
                Console.WriteLine("Alarm cali");
                AlarmCaldi(this);
            }
            else if(alarmitetikleyen is Sigara)
            {
                Console.WriteLine("sigara yandi alarm caldi");
            }
        }
    }
}

