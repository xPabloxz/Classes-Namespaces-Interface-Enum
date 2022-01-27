// https://docs.microsoft.com/pt-br/dotnet/?view=net-5.0
using System;
using Csharp;
using Interface;
using Enum;

namespace Primeiro
{
    class Classe
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Giovana;
            Pessoas pessoa3 = (Pessoas)2;
            Pessoas pessoa4 = (Pessoas)3;
            Pessoas pessoa5 = (Pessoas)4;
            Pessoas pessoa6 = (Pessoas)5;

            Pessoa person = new Pessoa();

            person.Nome = "Pablo";
            person.Idade = 24;
            person.Estado = "PE";

            var person2 = new Pessoa();

            person2.Nome = "Giovana";
            person2.Idade = 18;
            person2.Estado = "SP";

            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.NomeDono = "Pedro";
            animal.Especie = "Cachorro";

            string a = "Hello ";
            string b = "World!";
            Console.WriteLine(a + b);
            Console.WriteLine(pessoa3);
        }
    }
}