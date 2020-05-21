namespace GameTop
{
     public class Jogador1 : IJogador
    {
        public readonly string Nome;

        public Jogador1(string nome = "Washington")
        {
           Nome = nome;   
        }
        //Chutar
        public string Chutar(){
            return $"{Nome} esta chutando";
        }
        //Correr
        public string Correr(){
             return $"{Nome} esta correndo";
        }
        //Passar
        public string Passar(){
             return $"{Nome} esta passando";
        }
    }
}