

using BandaTocarDomain.Interfaces;

namespace BandaTocarDomain.Services {

    public class CommandTecnicoDeLuz : ICommand
    {
        public void execute()
        {
            System.Console.WriteLine("Testando luzes do show.");
        }
    }
}