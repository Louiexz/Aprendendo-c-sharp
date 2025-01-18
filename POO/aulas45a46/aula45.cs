using System;

// Array de Objetos
// Métodos: Retorno de Objeto
struct Objeto
{
    public string nome, material, fabricacao;
    public float peso;
    
    public Objeto(string nome, string material, string fabricacao, float peso)
    {
        this.nome = nome;
        this.material = material;
        this.fabricacao = fabricacao;
        this.peso = peso;
    }

    public override string ToString()
    {
        return $"Nome......: {nome},\nMaterial..: {material},\nPeso......: {peso},\nFabricação: {fabricacao}";
    }
}

struct ObjetosColecao {
    public Objeto[] obj;
    private int obj_len;

    public ObjetosColecao(int itens){
        obj = new Objeto[itens];
        obj_len = 0;
    }
    
    public void addObjeto(string nome, string material, string fabricacao, float peso){
        if (obj_len < obj.Length)  // Ensure there is space in the array
        {
            obj[obj_len] = new Objeto(nome, material, fabricacao, peso);
            obj_len++;  // Increment the count of objects
        }
        else
        {
            Console.WriteLine("Cannot add more objects. The collection is full.");
        }
    }
    
    public Objeto getObjeto(int index)
    {
        if (index >= 0 && index < obj_len)
        {
            return obj[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }
    }
}

class Aula45
{
    public static void Main()
    {
        int arrayLenght = 2;
        
        ObjetosColecao colecao = new ObjetosColecao(arrayLenght);
        
        colecao.addObjeto("Cadeira", "Madeira", "01/01/2024", 2);
        colecao.addObjeto("Mesa", "Madeira", "05/01/2024", 5);
       
       for (int i = 0; i < arrayLenght; i++){
           Console.WriteLine("Obj 1:\n{0}\n", colecao.getObjeto(i).ToString());
       }
    }
}
