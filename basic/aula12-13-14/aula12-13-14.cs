using System;
// Utilizando condições
class Aula12 {

    static void Main(){
        float nota = float.Parse(Console.ReadLine());
        string classificacao = "Desclassificado.";

        if (nota > 10 | nota < 0) {
            classificacao = "Desclassificado.";
        } else if (nota >= 6) {
            classificacao = "Aprovado.";

            if (nota == 10) {
                classificacao += " Nota máxima!";
            }
        } else {
            classificacao = "Reprovado.";
        }

        Console.WriteLine("Sua classificação: {0} ", classificacao);
    }
}