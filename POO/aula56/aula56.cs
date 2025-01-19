using System;
using System.Collections.Generic;

// utilizando LinkedList
class Aula55{
    static void Main(){
        LinkedList <string> valores = new LinkedList <string>();

        valores.AddFirst("Tv");
        valores.AddLast("Controle");
        valores.AddFirst("Sofa");

        LinkedListNode<string>no;
        no=valores.FindLast("Tv");
        valores.AddBefore(no, "Mesa de sala");
        valores.AddAfter(no, "Rack");
        
        //valores.Clear();

        foreach(string valor in valores){
            Console.WriteLine("Valores: {0}", valor);
        }
        
        valores.Remove("Tv");
        
        /*if (valores.Find("Tv")){
            Console.WriteLine("\nEncontrado\n");
        } else {
            Console.WriteLine("\nNão encontrado\n");
        }*/

        valores.RemoveFirst();
        valores.RemoveLast();
        
        Console.WriteLine("");
        
        foreach(string valor in valores){
            Console.WriteLine("Valores: {0}", valor);
        }
    }
}
