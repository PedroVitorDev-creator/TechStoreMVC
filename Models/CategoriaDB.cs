namespace TechStoreMVC.Models;

public class CategoriasDB
{
    private static readonly List<Categoria> categorias = new()
    {
        new Categoria(1, "Periféricos", "Mouses, teclados e acessórios"),
        new Categoria(2, "Monitores", "Monitores LED, OLED e ultrawide"),
        new Categoria(3, "Áudio", "Headsets, caixas de som e microfones")
    };

    public List<Categoria> Listar()
    {
        return categorias;
    }

    public Categoria? buscarPorId(int id)
    {
        return categorias.FirstOrDefault(c => c.Id == id);
    }

    public void Adicionar(Categoria categoria)
    {
        categoria.Id = categorias.Count > 0 ? categorias.Max(c => c.Id) + 1 : 1;
        categorias.Add(categoria);
    }

    public bool Atualizar(Categoria categoriaAtualizada)
    {
        Categoria? categoriaExistente = buscarPorId(categoriaAtualizada.Id);
        if (categoriaExistente is null)
            return false;

        categoriaExistente.Nome = categoriaAtualizada.Nome;
        categoriaExistente.Descricao = categoriaAtualizada.Descricao;
        return true;
    }

    public bool Excluir(int id)
    {
        Categoria? categoria = buscarPorId(id);
        if (categoria is null)
            return false;

        categorias.Remove(categoria);
        return true;
    }
}