using System;
using System.Collections.Generic;

// Utilizando Queue

class Aula59{
    static void Main(){
        string[] quarto = {"Cama", "Cabeceira", "Guarda-Roupa"};
        Queue <string> valores = new Queue <string>(quarto);

        valores.Enqueue("Mesa");
        
        //valores.Clear();

        Console.WriteLine($"Tamanho da fila: {valores.Count}\n");
        if (valores.Contains("Cabeceira")){
            Console.WriteLine("O valor existe na fila.");
        } else {
            Console.WriteLine("O valor não existe na fila.");
        }
        
        Console.WriteLine($"\nValor pego e retirado: {valores.Dequeue()}.");
        Console.WriteLine($"\nValor pego: {valores.Peek()}.");
        
        Console.WriteLine($"\nTamanho da fila: {valores.Count}\n");
    }
}