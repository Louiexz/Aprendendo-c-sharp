using System;
using System.Collections.Generic;

// utilizando List

class Aula57{
    static void Main(){
        List <string> valores = new List <string>();
        List <string> valoresTwo = new List <string>();

        valores.Add("Tv");
        valores.Add("Controle");
        valores.Add("Sofa");
        
        valoresTwo.AddRange(valores);

        valoresTwo.Add("Mesa de sala");
        valoresTwo.Add("Rack");
        
        //valores.Clear();
        
        valoresTwo.Remove("Tv");
        
        Console.WriteLine($"Contador: {valores.Count}");
        Console.WriteLine($"Capacidade: {valores.Capacity}\n");
        
        if (valores.Contains("Tv")){
            Console.WriteLine("Valor encontrado\n");
        } else {
            Console.WriteLine("Valor não encontrado\n");
        }
        
        foreach(string valor in valoresTwo){
            Console.WriteLine($"Valores Two: {valor},");
            Console.WriteLine($"Index: {valoresTwo.IndexOf(valor) + 1}\n");
        }
        
        valores.Insert(1, "Tv");
        Console.WriteLine("Último index de Tv: {0}\n", valores.LastIndexOf("Tv") + 1);
        valores.RemoveAt(2);
        
        foreach(string valor in valores){
            Console.WriteLine($"Valores: {valor},");
            Console.WriteLine($"Index: {valoresTwo.IndexOf(valor) + 1}\n");
        }
    }
}
