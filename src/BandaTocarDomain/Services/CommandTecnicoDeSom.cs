
using BandaTocarDomain.Interfaces;

namespace BandaTocarDomain.Services {

    public class CommandTecnicoDeSom : ICommand
    {
        public string execute()
        {
            return "Testando volume da banda na mesa.";
        }
    }
}