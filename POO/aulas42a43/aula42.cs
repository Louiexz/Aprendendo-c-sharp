using System;
// Classes: Indexadores e Interfaces

interface IArma
{

    string GetCategoria();
    string GetMunicao();
    string GetTipo();
}

class Arma: IArma
{
    protected string categoria, municao, tipo, modelo = "";

    public string GetCategoria() => categoria;
    public string Modelo {
        get => modelo;
        set { modelo = value; }
    }
    public string GetMunicao() => municao;
    public string GetTipo() => tipo;
}

class Arco : Arma
{
    public Arco() {
        categoria = "Arco";
        tipo = "madeira";
        municao = "flecha";
    }
}

class Metralhadora : Arma
{
    public Metralhadora() {
        categoria = "Metralhadora";
        municao = "balas";
        tipo = ".50";
    }
}

class Pistola : Arma
{
    public Pistola() {
        categoria = "Pistola";
        municao = "balas";
        tipo = "9mm";
    }
}

class ArmaColecao
{
    // Array to hold different weapon types
    public Arma[] armas = new Arma[]{new Pistola(), new Metralhadora(), new Arco()};

    // Method to get the weapon by index
    public Arma GetArma(int arma) => armas[arma];

    // Simplified ToString method
    public string ToString(Arma selectedArma) {
        string msg = $"Categoria: {selectedArma.GetCategoria()},";

        if (!string.IsNullOrEmpty(selectedArma.Modelo)) {
            msg += $" Modelo: {selectedArma.Modelo},";
        }

        return msg + $"\nMunição: {selectedArma.GetMunicao()}, Tipo: {selectedArma.GetTipo()}.";
    }
}

class Aula42
{
    public static void Main()
    {
        ArmaColecao armas = new ArmaColecao();
        var selectedArma = armas.GetArma(0);
        
        selectedArma.Modelo = "Glock";
        
        Console.WriteLine(armas.ToString(selectedArma));
    }
}
