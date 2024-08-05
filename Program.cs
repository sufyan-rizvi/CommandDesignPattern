using CommandDesignPattern.Models;

namespace CommandDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();
            RemoteControl remote = new RemoteControl();
            ICommand OnComman = new OnCommand(tv);
            remote.Command = OnComman;
            remote.PressButton();

            ICommand OffComman = new OffCommand(tv);
            remote.Command = OffComman;
            remote.PressButton();


        }
    }
}
