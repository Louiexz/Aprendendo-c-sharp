using System;
// Lendo inputs
class Welcome
{
    static void Main(string[] args)    {
        string profissao;
        float salario;
        int idade;

        Console.Write("Sua profissão: ");
        profissao=Console.ReadLine();

        Console.WriteLine("Seu salário: ");
        salario = (float.Parse(Console.ReadLine()));

        Console.WriteLine("Sua idade: ");
        idade = (int.Parse(Console.ReadLine()));

        Console.WriteLine("Sua profissão: {0}", profissao);
        Console.WriteLine("Seu salário: {0:c}",salario);
        Console.WriteLine("Sua idade: {0:p}",idade);
    }
}