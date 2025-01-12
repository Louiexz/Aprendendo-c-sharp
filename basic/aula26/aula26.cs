using System;

class Aula26 {
    static string Pessoa(out string reino, string nome = "Desconhecido"){
        reino = "Mammalia";
        return nome;
    }

    static void Main(){
        string reino, nome = Pessoa(out reino);
 
        Console.WriteLine($"Seu nome: {nome} e reino: {reino}");
        
        string reinoTwo, nomeTwo = Pessoa(out reinoTwo, "Napoleão");
        Console.WriteLine($"Seu nome: {nomeTwo} e reino: {reinoTwo}");
    }
}