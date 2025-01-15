using System;
// Array e Loop: Foreach

class AulasDezesseteVinteDois {
  static void Main() {
    int[] n = new int[3]{19, 20, 21};
    
    inicio:
    
    try{
        for(int i=0; i < n.Length; i++){
            Console.WriteLine("Por favor. Digite um número? ");
            n[i] = int.Parse(Console.ReadLine());
        }
    } catch (Exception) {
        Console.WriteLine("Por favor. Digite apenas números inteiros.");
        goto inicio;
    }
    Console.WriteLine();
    
    foreach(int num in n){
        Console.WriteLine("Números: {0}",num);
    }
    
    Console.WriteLine("\nDeseja continuar? ");
    string choose = Console.ReadLine();
    
    while (choose == "s" | choose == "sim"){
        goto inicio;
    }
  }
}