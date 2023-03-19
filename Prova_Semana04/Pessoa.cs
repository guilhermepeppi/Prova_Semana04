namespace Prova_Semana04;

public class Pessoa
{
    //Atributos
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public List<Livros> LivrosEmprestados { get; set; }

    
    public void AdicionarLivroLista(int Livro)
    {
        LivrosEmprestados.Add();
    }
    
    public int RemoverLivroLista(int idLivro)
    {
        LivrosEmprestados.RemoveAt(idLivro);
        return idLivro;
    }
}

