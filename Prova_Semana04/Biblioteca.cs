namespace Prova_Semana04;

public class Biblioteca
{
    //Atributos
    public List<Pessoa> Pessoas { get; set; } = null!;
    public List<Livros> Livros { get; set; } = null!;


    //Métodos:

    //CadastrarPessoa(Pessoa) - Deverá incluir uma pessoa na lista Pessoas do objeto Biblioteca;
    public void CadastrarPessoa(int Pessoa)
    {
        Pessoa pessoa = new Pessoa();
        Console.WriteLine("Digite o ID: ");
        Console.ReadLine();

        foreach (int id in pessoa.Id)
            if (id == pessoa.Id)
                Console.WriteLine("Pessoa já cadastrada");
            else
                pessoa.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Nome: ");
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine("Digite o CPF: ");
        pessoa.Cpf = Console.ReadLine();

        Console.WriteLine("Digite o telefone: ");
        pessoa.Telefone = Console.ReadLine();

        pessoa.LivrosEmprestados.Clear(); //Limpa os Livros emprestados
    }


    //CadastrarLivro(Livro) - Deverá incluir um livro na lista de Livros do objeto Biblioteca;
    public void CadastrarLivro(int Livro)
    {
        Livros livro = new Livros();

        Console.WriteLine("Digite o ID: ");
        livro.Id = int.Parse(Console.ReadLine());

        foreach (int id in livro.Id)
            if (id == livro.Id)
                Console.WriteLine("Livro já cadastrado");
            else
                livro.Id = int.Parse(Console.ReadLine());
                

        Console.WriteLine("Digite o Título: ");
        livro.Titulo = Console.ReadLine();

        Console.WriteLine("Digite o autor: ");
        livro.Autor = Console.ReadLine();

        Console.WriteLine("Digite a editora: ");
        livro.Editora = Console.ReadLine();

        Console.WriteLine("Digite a quantidade de exemplares: ");
        livro.QuantidadeExemplares = int.Parse(Console.ReadLine());
    }


    //EmprestarLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método EmprestarLivro do objeto Livro
    // e Adicionar um Livro na lista LivrosEmprestados do objeto Pessoa através do método AdicionarLivroLista;
    public int EmprestarLivroBiblioteca(int idLivro, int idPessoa)
    {
        
    }


    //DevolverLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método DevolverLivro do
    // objeto Livro e Remover um Livro na lista LivrosEmprestados do objeto Pessoa através
    // do método RemoverLivroLista;
    public int DevolverLivroBiblioteca(int idLivro, int idPessoa)
    {
        
        return 0;
    }
}