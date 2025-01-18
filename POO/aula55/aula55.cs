using System;
using System.Collections.Generic;
// utilizando Dicionários

class Aula55{
    static void Main(){
        Dictionary <int, string> valores = new Dictionary <int, string>();

        valores.Add(1, "Cadeira");
        valores.Add(2, "Mesa");
        valores.Add(3, "Toalha");


        //valores.Clear();
        Console.WriteLine($"Tamanho Dict: {valores.Count}\n");
        
        valores.Remove(3);
        
        foreach(KeyValuePair<int, string> item in valores) {
            Console.WriteLine($"Valores Dict: {item.Value}, index: {item.Key}");
        }
        
        if (valores.ContainsKey(2)){
            Console.WriteLine("\nContém a key");
        } else {
            Console.WriteLine("\nNão contém a key");
        }
        
        if (valores.ContainsValue("Toalha")){
            Console.WriteLine("\nContém o valor");
        } else {
            Console.WriteLine("\nNão contém o valor");
        }
    }
}