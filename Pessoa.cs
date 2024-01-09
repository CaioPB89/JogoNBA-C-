using System;
//o comum entre as classes
namespace Pes
{
    public class Pessoa
    {
        public Pessoa(string nome,DateOnly nasc)
        {
            Nome=nome;
            Nasc=nasc;
            
        }
        public string? Nome {get;private set;}
        public DateOnly Nasc {get;private set;}
        
    }
}