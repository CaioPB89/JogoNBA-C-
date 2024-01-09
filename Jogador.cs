using System;
using Pes;//vai usar herança

namespace Jog
{
    public class Jogador : Pessoa
    {
        public Jogador(string nome,DateOnly nasc,double alt,double peso,string posi)
                :base(nome,nasc)
        {
            Alt=alt;
            Peso=peso;
            Posi=posi;

        }
        public double Alt{get;private set;}
        public double Peso{get;private set;}
        public string? Posi{get;private set;}
    }
}