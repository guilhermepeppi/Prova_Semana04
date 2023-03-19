namespace Prova_Semana04;

public class Pessoa
{
    //Atributos
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Cpf { get; set; } = null!;
    public string Telefone { get; set; } = null!;
    public List<Livros> LivrosEmprestados { get; set; } = null!;


    public int AdicionarLivroLista(int Livro)
    {
        LivrosEmprestados.Add();
    }

    public int RemoverLivroLista(int idLivro)
    {
        LivrosEmprestados.RemoveAt(idLivro);
        return idLivro;
    }
}