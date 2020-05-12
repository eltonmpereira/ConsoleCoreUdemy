
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public readonly string _Nome;

        public Jogador2(string nome = "Maradona")
        {
            _Nome = nome;
        }

        //chuta
        public string Chuta()
        {
            return $"{_Nome} está pateando";
        }

        //corre
        public string Corre()
        {
            return $"{_Nome} está corriendo";
        }

        //Passe
        public string Passe()
        {
            return $"{_Nome} está passando";
        }
    }
}