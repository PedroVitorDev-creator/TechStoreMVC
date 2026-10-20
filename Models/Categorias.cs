    public class Categoria
    {
        public int Id {get;set;}

        public string Nome {get; set;}

        public string Descricao {get; set;}

        public bool Ativa {get; set;}
        
    public Categoria (
        int id,
        string nome,
        decimal descricao,
        int ativa
    )
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Ativa = ativa;
    }
    }