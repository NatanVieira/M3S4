

using BandaTocarDomain.Interfaces;

namespace BandaTocarDomain.Models {

    public class BandaTocarModel {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string NomeMusica { get; set; }
        public int Sequencia { get; set; }

        public ICommand Interagir {get; set;}
        public ICommand TestarLuzes {get; set;}
        public ICommand TestarSom {get; set;}
        public BandaTocarModel(){

        }

        public BandaTocarModel(string descricao, string nomeMusica, int sequencia){
            Descricao = descricao;
            NomeMusica = nomeMusica;
            Sequencia = sequencia;
            CriaId();
        }

        private void CriaId(){
            Id = new Random().Next();
        }
    }
}