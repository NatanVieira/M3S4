

using BandaTocarDomain.Interfaces;

namespace BandaTocarDomain.Services {


    public class CommandBanda : ICommand
    {
        public string execute()
        {
            return "Interagindo com o público!!!";
        }
    }
}