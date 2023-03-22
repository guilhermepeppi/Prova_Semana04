using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Semana04;

internal class Biblioteca
{

    //Atributos
    private List<Pessoa> Pessoas { get; set; }
    private List<Livros> Livros { get; set; }


    //Métodos:

    //CadastrarPessoa(Pessoa) - Deverá incluir uma pessoa na lista Pessoas do objeto Biblioteca;
    public void CadastrarPessoa(Pessoa pessoas)
    {
        string nome, cpf, telefone;
        int id = 0;

        // Solicitando dados de entrada
        Console.WriteLine("Digite o ID: ");
        Console.ReadLine();

        ConsultarPessoasPorId(id);

        if (true)
        {
            Console.WriteLine("Pessoa já cadastrada");
        }
        else
        {

            Console.WriteLine("Digite o Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            cpf = Console.ReadLine();

            Console.WriteLine("Digite o telefone: ");
            telefone = Console.ReadLine();

            // Instanciando a pessoa
            Pessoa pessoa = new Pessoa(id++, nome, cpf, telefone);

            // Instanciando a biblioteca para guardar os dados da pessoa
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.CadastrarPessoa(pessoa);
        }
    }


    //CadastrarLivro(Livro) - Deverá incluir um livro na lista de Livros do objeto Biblioteca;
    public void CadastrarLivro(Livros livros)
    {
        string nomeLivro, autor, editora;
        int quantidadeExemplares, id = 0;

        // Solicitando dados de entrada
        Console.WriteLine("Digite o ID: ");
        Console.ReadLine();

        ConsultarLivrosPorId(id);

        if (true)
        {
            Console.WriteLine("Livro já cadastrado");
        }
        else
        {
            Console.WriteLine("Informe o nome do novo livro: ");
            nomeLivro = Console.ReadLine();

            Console.WriteLine("Informe o nome do autor do livro: ");
            autor = Console.ReadLine();

            Console.WriteLine("Informe o nome da editora do livro: ");
            editora = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de exemplares: ");
            quantidadeExemplares = int.Parse(Console.ReadLine());

            // Instanciando o livro
            Livros livro = new Livros(id++, nomeLivro, autor, editora);
            livro.AdicionarQuantidadeEstoque(quantidadeExemplares);

            // Instanciando a biblioteca para guardar o livro
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.CadastrarLivro(livro);
        }

    }


    //EmprestarLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método EmprestarLivro do objeto Livro
    // e Adicionar um Livro na lista LivrosEmprestados do objeto Pessoa através do método AdicionarLivroLista;
    public void EmprestarLivroBiblioteca(int idLivro, int idPessoa)
    {

    }


    //DevolverLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método DevolverLivro do
    // objeto Livro e Remover um Livro na lista LivrosEmprestados do objeto Pessoa através
    // do método RemoverLivroLista;
    public int DevolverLivroBiblioteca(int idLivro, int idPessoa)
    {
        //to do : Glaucia
        return 0;
    }

    public Livros ConsultarLivrosPorId(int id)
    {
        Livros livro = Livros.Where(livro => livro.ObterIdLivro() == id).FirstOrDefault();
        return livro;
    }

    public Pessoa ConsultarPessoasPorId(int id)
    {
        Pessoa pessoa = Pessoas.Where(pessoa => pessoa.ObterIdPessoa() == id).FirstOrDefault();
        return pessoa;
    }

    public void ImprimirRelatorioLivros()
    {
        foreach (var livro in Livros)
        {
            Console.WriteLine($"Livro: {livro.ObterNomeLivro()} Autor: {livro.ObterAutorLivro()}");
        }
    }

    public void ImprimirRelatorioPessoas()
    {
        foreach (var pessoa in Pessoas)
        {
            Console.WriteLine($"Nome: {pessoa.ObterNomePessoa()}");
        }
    }

    public void ImprimirLivrosEmprestados(int idPessoa)
    {
        Pessoa pessoa = ConsultarPessoasPorId(idPessoa);
        Console.WriteLine($"Livros emprestados por {pessoa}");

        if (pessoa.liv)
      
    }

}