using System;

class Aula25 {
    static void ProfissaoInput(string profissao){
        profissao += " :)";
    }

    static void ProfissaoInputReferencia(ref string profissao){
        profissao += " :)";
    }

     static void Main(){
        string profissao = "Desenvolvedor";

        ProfissaoInput(profissao);
        Console.WriteLine($"Sua profissão é: {profissao}");

        ProfissaoInputReferencia(ref profissao);
        Console.WriteLine($"Sua profissão é: {profissao}");
    }
}