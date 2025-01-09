using System;

class Welcome
{
    static void Main(string[] args)    {
        string profissao;
        float salario;
        int idade;

        Console.Write("Sua profissão: ");
        profissao=Console.ReadLine();

        Console.WriteLine("Seu salário: ");
        salario=float.Parse(Console.ReadLine());

        Console.WriteLine("Sua idade: ");
        idade = Convert.ToFloat(Console.ReadLine());

        Console.WriteLine("Sua profissão: {0}", profissao);
        Console.WriteLine("\nSeu salário: {0,15:c}",salario);
        Console.WriteLine("\nSua idade: {0}",idade);
    }
    void print{
        Console.WriteLine(profissao);

        return variavel;
    }
}