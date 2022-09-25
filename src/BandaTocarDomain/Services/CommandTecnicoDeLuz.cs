

using BandaTocarDomain.Interfaces;

namespace BandaTocarDomain.Services {

    public class CommandTecnicoDeLuz : ICommand
    {
        public string execute()
        {
            return "Testando luzes do show.";
        }
    }
}