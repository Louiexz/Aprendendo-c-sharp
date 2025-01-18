using System;
// Struct

struct ObjetoColecao{
    public string nome, material, fabricacao;
    public float peso;
    
    public ObjetoColecao(string nome, string material, string fabricacao, float peso){
        this.nome = nome;
        this.material = material;
        this.fabricacao = fabricacao;
        this.peso = peso;
    }

    public override string ToString(){
        return $"Nome......: {nome},\nMaterial..: {material},\nPeso......: {peso},\nFabricação: {fabricacao}";
    }
}

class Aula44
{
    public static void Main()
    {
        ObjetoColecao obj = new ObjetoColecao("Cadeira", "Madeira", "01/01/2024", 2);
        
        Console.Write(obj.ToString());
    }
}