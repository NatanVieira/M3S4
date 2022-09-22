
using BandaTocarDomain.Interfaces;

namespace BandaTocarDomain.Services {

    public class CommandTecnicoDeSom : ICommand
    {
        public void execute()
        {
            System.Console.WriteLine("Testando volume da banda na mesa.");
        }
    }
}