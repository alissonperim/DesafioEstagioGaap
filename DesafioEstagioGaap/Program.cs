using System;

namespace DesafioEstagioGaap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Existem duas soluções para este exercício,
            //primeira solução: 

            Console.WriteLine("Digite uma palavra: ");
            string OriginalWord = Console.ReadLine();
            char[] Letters = OriginalWord.ToCharArray();
            string ConstructedWord = String.Empty;

            for (int i = Letters.Length - 1; i > -1; i--)
            {
                ConstructedWord += Letters[i];
            }

            Console.WriteLine($"O reverso de {OriginalWord} é: {ConstructedWord}.");
            Console.WriteLine(OriginalWord.ToLower() == ConstructedWord.ToLower() && OriginalWord != "" ? "A palavra é um palíndrono!" : "A palavra não é um palíndrono, ou você não digitou nada.");


            //segunda solução:
            Console.WriteLine("\nDigite uma palavra: ");
            var Original = Console.ReadLine();
            char[] Letter = Original.ToCharArray();
            Array.Reverse(Letter);
            var Constructed = new string(Letter);
            Console.WriteLine($"O reverso de {Original} é: {Constructed}.");
            Console.WriteLine(Original.ToLower() == Constructed.ToLower() && Original != "" ? "A palavra é um palíndrono!" : "A palavra não é um palíndrono, ou você não digitou nada.");
        }
    }
}
