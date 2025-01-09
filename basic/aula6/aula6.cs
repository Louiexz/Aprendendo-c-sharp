using System;
// printando variáveis e formatando saídas
class Welcome
{
    static void Main(string[] args)    {
        var profissao = "Desenvolvedor";
        float salario = 450f;

        Console.WriteLine("Sua profissão: {0}", profissao);
        Console.WriteLine("Seu salário: {0,15:p}",salario);
        Console.WriteLine("Seu salário: {0,15:c}",salario);
    }
    void print(){
        //Console.WriteLine(profissao);

        //return variavel;
    }
}