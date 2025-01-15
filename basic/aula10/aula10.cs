using System;
// Enum: necessários para criar tipos personalizados com valores predefinidos
class Aula10 {
    enum FimDeSemana{Sabado, Domingo};

    static void Main(){
        int dfs = (int)FimDeSemana.Domingo;

        Console.WriteLine(dfs);
    }
}