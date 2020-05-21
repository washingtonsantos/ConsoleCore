using System;

namespace GameTop
{
    public class JogoFoda
    {        
        private readonly IJogador _jogador;
        private readonly IJogador _jogadorB;
       public JogoFoda(IJogador jogador, IJogador jogadorB)
       {
           _jogador = jogador;
           _jogadorB = jogadorB;
       }

       public void IniciarJogo()
       {
           Console.WriteLine(_jogador.Correr());
           Console.WriteLine(_jogador.Chutar());
           Console.WriteLine(_jogador.Passar());

           Console.WriteLine("Próximo Jogador");

           Console.WriteLine(_jogadorB.Correr());
           Console.WriteLine(_jogadorB.Chutar());
           Console.WriteLine(_jogadorB.Passar());
       }
    }
}