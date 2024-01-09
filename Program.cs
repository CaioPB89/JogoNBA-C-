using System;
using Pes;
using Tec;
using Jog;
using Tim;
using System.Globalization;
  namespace Jogo
  {
    class Program
    {

        static void Main()
        {
          int alas=0; int pivo=0;int armador=0; //variaveis para a contagem das posições
          var time1=new List<Jogador>();//lista para guardar os jogadores
          var time2=new List<Jogador>();//lista para guardar os jogadores
          var listarb=new List<string>();//para guardar os arbitros, se for necessario
          Console.WriteLine("Qual o ano dessa temporada?(Inicio/Fim)");
          string? ano=Console.ReadLine();
          int loop=1;
          while (loop==1)//loop da liga
          {
            Console.WriteLine("---Gerenciamento de jogos da temporada---");
            Console.WriteLine("Um jogo é composto por 2 times de 5 jogadores e um técnico");
            Console.WriteLine("Qual o nome do time da casa?");
            string? tim1=Console.ReadLine();
            Console.WriteLine("Ele é do leste ou oeste?");
            string? ool=Console.ReadLine();
            for (int i=1;i<=5;i++)
            {
              Console.WriteLine($"Qual o nome do {i}º jogador?");
              string? name=Console.ReadLine();
              Console.WriteLine("Qual a data de nascimento?(Dia/Mês/Ano)");
              string? nasc=Console.ReadLine();
              var resul=DateOnly.ParseExact(nasc!,"dd/MM/yyyy",new CultureInfo("pt-BR"));//coverter  nesse formato

              Console.WriteLine("Qual o tamanho deste jogador?(M)");
              Double alt=Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Qual o peso deste jogador?(Kg)");
              Double peso=Convert.ToDouble(Console.ReadLine());
              int loopposi=0;
              while (loopposi==0)
              {
              Console.WriteLine("Qual a posição deste jogador?(2 Ala,2 Pivô e 1 Armador)");
              Console.WriteLine($"No momento, temos {alas} alas, {pivo} pivôs e {armador} armador no time");
              string? posi=Console.ReadLine();
              switch(posi!.ToLower())
              {
                case "ala":
                alas++;
                if (alas>2)
                {
                  Console.WriteLine("Já temos o limite de alas,escolha outra posição.");
                  alas--;
                }
                else
                {
                loopposi=1;
                Jogador j=new Jogador(name!,resul,alt,peso,posi!);
                time1.Add(j);//salvando os jogadores na lista
               
                }
                break;
                case "pivô":
                pivo++;
                if (pivo>2)
                {
                  Console.WriteLine("Já temos o limite de pivôs,escolha outra posição.");
                  pivo--;
                }
                else
                {
                loopposi=1;
                Jogador j=new Jogador(name!,resul,alt,peso,posi!);
                time1.Add(j);//salvando os jogadores na lista
                }
                break;
                case "armador":
                armador++;
                if (armador>1)
                {
                  Console.WriteLine("Já temos o limite de armadores,escolha outra posição.");
                  armador--;
                }
                else
                {
                loopposi=1;
                Jogador j=new Jogador(name!,resul,alt,peso,posi!);
                time1.Add(j);//salvando os jogadores na lista
                }
                break;
                default:
                Console.WriteLine("Posição inválida");
                break;
              }
            }
              
              }
              Console.WriteLine("O técnico desse time se chama?");
              string? nt1=Console.ReadLine();
              Console.WriteLine("Quando ele nasceu?");
              string? nast1=Console.ReadLine();
              var pop=DateOnly.ParseExact(nast1!,"dd/MM/yyyy",new CultureInfo("pt-BR"));
              Console.WriteLine("Quantos anos de experiência em ser técnico?");
              int anos=Convert.ToInt32(Console.ReadLine());
              Tecnico t1=new Tecnico(nt1!,pop,anos);
              //fim do tec 1
              //fim do time 1


            alas=0; pivo=0; armador=0;//volta as variaveis de contagem a 0 para usar no outro time
            Console.WriteLine("Qual o nome do time visitante?");//nome
            string? tim2=Console.ReadLine();
            Console.WriteLine("Ele é do leste ou oeste?");//local
            string? loo=Console.ReadLine();
            for (int i=1;i<=5;i++)
            {
              Console.WriteLine($"Qual o nome do {i}º jogador?");//nome
              string? name=Console.ReadLine();
              Console.WriteLine("Qual a data de nascimento?(Dia/Mês/Ano)");//nascimento
              string? nasc=Console.ReadLine();
              var resul=DateOnly.ParseExact(nasc!,"dd/MM/yyyy",new CultureInfo("pt-BR"));
              Console.WriteLine("Qual o tamanho deste jogador?(M)");//altura
              Double alt=Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Qual o peso deste jogador?(Kg)");//peso
              Double peso=Convert.ToDouble(Console.ReadLine());
              //um sistema para checar se a posição é valida para o time
              //se for, add o jogador no time, se não, retorna o loop
              int loopposi=0;
              while (loopposi==0)
              {
              Console.WriteLine("Qual a posição deste jogador?(2 Ala,2 Pivô e 1 Armador)");
              Console.WriteLine($"No momento, temos {alas} alas, {pivo} pivôs e {armador} armador no time");
              string? posi=Console.ReadLine();
              switch(posi!.ToLower())
              {
                case "ala":
                alas++;
                if (alas>2)
                {
                  Console.WriteLine("Já temos o limite de alas,escolha outra posição.");
                  alas--;
                }
                else
                {
                loopposi=1;
                Jogador j=new Jogador(name!,resul,alt,peso,posi!);
                time2.Add(j);//salvando os jogadores na lista
                }
                break;
                case "pivô":
                pivo++;
                if (pivo>2)
                {
                  Console.WriteLine("Já temos o limite de pivôs,escolha outra posição.");
                  pivo--;
                }
                else
                {
                loopposi=1;
                Jogador j=new Jogador(name!,resul,alt,peso,posi!);
                time2.Add(j);//salvando os jogadores na lista
                }
                break;
                case "armador":
                armador++;
                if (armador>1)
                {
                  Console.WriteLine("Já temos o limite de armadores,escolha outra posição.");
                  armador--;
                }
                else
                {
                loopposi=1;
                Jogador j=new Jogador(name!,resul,alt,peso,posi!);
                time2.Add(j);//salvando os jogadores na lista
                }
                break;
                default:
                Console.WriteLine("Posição inválida");
                break;
              }
            }
              }
              Console.WriteLine("O técnico desse time se chama?");//nome
              string? nt2=Console.ReadLine();
              Console.WriteLine("Quando ele nasceu?");//nascimento
              string? nast2=Console.ReadLine();
              var pop2=DateOnly.ParseExact(nast2!,"dd/MM/yyyy",new CultureInfo("pt-BR"));
              Console.WriteLine("Quantos anos de experiência em ser técnico?");//experiência
              int anos2=Convert.ToInt32(Console.ReadLine());
              Tecnico t2=new Tecnico(nt2!,pop2,anos2);//instância o tecnico do segundo time
              //fim do tec 2
              //fim do time 2

           
            arbi(listarb);//envio a lista para a função
            //fim de arbitros
            //placar
            Console.WriteLine($"A pontuação do time {tim1} foi:" );
            int pont1=Convert.ToInt32(Console.ReadLine());
            var timez1=new Time(tim1!,ool!,pont1,time1,t1);//instânciado uma classe pra time 1
                                                     //que tbm salva os jogadores e o tecnico
            Console.WriteLine($"A pontuação do time {tim2} foi:" );
            int pont2=Convert.ToInt32(Console.ReadLine());
            var timez2=new Time(tim2!,loo!,pont2,time2,t2);

            if (timez1.Placar>timez2.Placar)
            Console.WriteLine($"Vitória do time {timez1.NTime}");
            else if (timez1.Placar<timez2.Placar)
             Console.WriteLine($"Vitória do time {timez2.NTime}");
             else 
             Console.WriteLine("Empate");
          //fim do placar
          int loop2=0;
          while (loop2==0)
          {
          Console.WriteLine("Tem mais algum jogo na temporada?(Sim/Não)");
          string? resposta=Console.ReadLine();
          switch (resposta!.ToLower())
          {
            case "não":
            Console.WriteLine("Terminado o gerenciamento");
            loop=0;
            loop2=1;
            break;
            case "sim":
            Console.WriteLine("Continuando...");
            loop2=1;
            break;
            default:
            Console.WriteLine("Resposta inválida");
            break;
            }//fecha o case
          }//fecha o loop de perguntar se tem jogo
            } //fecha o loop do gerenciamento de times
            var listatodos=time1.Concat(time2);//concatenado as duas listas em um
            Console.WriteLine("Dos jogadores abaixo, qual foi o melhor?");
            foreach(var n in listatodos)
            {
            Console.WriteLine($"Jodador {n.Nome} Posição {n.Posi}");
            }
            string? melhor=Console.ReadLine();
          //fim do melhor jogador
            var jogalto =listatodos.OrderByDescending(x => x.Alt);
            var nomealto=jogalto.First();//pega o primeiro da lista de maio altura
            var lista2=new List<Jogador>();//cria uma lista para receber a var pessoa
            lista2.Add(nomealto);//adiciona a maior pessoa aqui
            foreach(var o in lista2)
            {
              Console.WriteLine($"O jogador mais alto foi: {o.Nome}");//lê o valor nome
              Console.WriteLine($"Com: {o.Alt}");//lê o valor altura do mais alto
            }
            //fim do maior jogador
           
            
            


          }
          static void arbi(List<string> listarb)
          {
           
            Console.WriteLine("O jogo possui 3 arbitros, informe o nome deles.");
            for (int a=1;a<=3;a++)
            {
              Console.WriteLine($"Informe o {a}º arbitro");
              string? arb=Console.ReadLine();
              listarb.Add(arb!);
            }


          }


            
        }

        




        




    
    }




  
