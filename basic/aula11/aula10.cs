using System;
// Typecast (Conversão insegura)
class Aula11 {

    static void Main(){
        float numero = 10.5f;
        int numeroCast = (int)numero;
        short numeroShort = (short)numeroCast;
        
        Console.WriteLine("{0} e {1}",numeroCast, numeroShort);
    }
}