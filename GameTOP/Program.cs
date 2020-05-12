using System;
using GameTOP.Lib;
using GameTOP.Lib.obj;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(
               new Jogador1(),
               new Jogador3()
            ); 
               
               
           jogo.IniciarJogo();
        }
    }

    
}
