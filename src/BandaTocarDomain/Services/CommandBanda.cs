

using BandaTocarDomain.Interfaces;

namespace BandaTocarDomain.Services {


    public class CommandBanda : ICommand
    {
        public void execute()
        {
            System.Console.WriteLine("Interagindo com o público!!!");
        }
    }
}