using System;
using Pes;//vai usar herança
namespace Tec
{
    public class Tecnico : Pessoa
    {
        public Tecnico(string nome,DateOnly nasc,int anos)
                :base(nome,nasc)
        {
            Anos=anos;
        }
        public int Anos{get;private set;}
        
    }
}