namespace TechStoreMVC.Models;

public class Produto
{
    // Passo 01 - Criar as Models
    //Atributos 

    public int Id {get; set;} // Get para obter um id = Identificador

    public string Nome {get; set;} // Set para definir um novo valor, atualizar e etc

    public decimal Preco {get; set;}

    public int Estoque {get; set;}
    // Método Construtor - DeFine Valores iniciais desses atributos acima!

    public Produto (
        int id,
        string nome,
        decimal preco,
        int estoque
    )
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}



