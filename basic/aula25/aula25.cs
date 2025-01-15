using System;
// Parametros: (ref)
class Aula26 {
    static string Pessoa(string nome, out string reino){
        reino = "Mammalia";
        return nome;
    }

     static void Main(){
        string reino, nome = "Luiz";
 
        Pessoa(nome, out reino);
        Console.WriteLine($"Seu nome: {nome} e reino: {reino}");
    }
}