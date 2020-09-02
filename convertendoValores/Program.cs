using System;

namespace convertendoValores
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string nome = null;
            int idade = 0;
      

            Console.WriteLine("Digite o seu nome: ");
            //solicitando o nome 
            nome = Console.ReadLine();


            Console.WriteLine("Digite a sua idade: ");
            //solicitando a idade  
            idade = int.Parse(Console.ReadLine());



            Console.WriteLine("Seu nome e: " + nome);
            Console.WriteLine("Sua idade e: " + idade);

            Console.WriteLine("Hello World!");
        }
    }
}
