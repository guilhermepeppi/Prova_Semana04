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

        if (ConsultarPessoasPorId(id) != null)

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

        if (ConsultarLivrosPorId(id) != null)
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
            Livros livro = new Livros(id++, nomeLivro, autor, editora, quantidadeExemplares);
            livro.EmprestarLivro(quantidadeExemplares);

            // Instanciando a biblioteca para guardar o livro
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.CadastrarLivro(livro);
        }
    }


    //EmprestarLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método EmprestarLivro do objeto Livro
    // e Adicionar um Livro na lista LivrosEmprestados do objeto Pessoa através do método AdicionarLivroLista;
    public void EmprestarLivroBiblioteca(int idLivro, int idPessoa)
    {
        //FALTA CHAMAR O MÉTODO EMPRESTARLIVRO
        Pessoa pessoa = ConsultarPessoasPorId(id);

        Console.WriteLine("Digite o ID da pessoa: ");
        idPessoa = int.Parse(Console.ReadLine());

        Pessoa pessoa = ConsultarPessoasPorId(idPessoa);

        if (pessoa.ObterIdPessoa() == 0)
        {
            Console.WriteLine("Pessoa não cadastrada");
        }
        else
        {
            Console.WriteLine("Digite o ID do livro: ");
            idLivro = int.Parse(Console.ReadLine());

            Livros livro = ConsultarLivrosPorId(idLivro);

            if (livro.ObterIdLivro() == 0)
            {
                Console.WriteLine("Livro não cadastrado");
            }
            else
            {
                Console.WriteLine($"O Livro {idLivro} foi emprestado para a pessoa {idPessoa} com sucesso");
            }
        }
    }


    //DevolverLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método DevolverLivro do
    // objeto Livro e Remover um Livro na lista LivrosEmprestados do objeto Pessoa através
    // do método RemoverLivroLista;
    public void DevolverLivroBiblioteca(int idLivro, int idPessoa)
    {
        //FALTA CHAMAR O MÉTODO DEVOLVERLIVRO

        Console.WriteLine("Digite o ID da pessoa: ");
        idPessoa = int.Parse(Console.ReadLine());

        ConsultarPessoasPorId(idPessoa);

        Pessoa pessoa = ConsultarPessoasPorId(idPessoa);

        if (pessoa.ObterIdPessoa() == 0)
        {
            Console.WriteLine("Pessoa não cadastrada");
        }
        else
        {
            Console.WriteLine("Digite o ID do livro: ");
            idLivro = int.Parse(Console.ReadLine());

            ConsultarLivrosPorId(idLivro);

            Livros livro = ConsultarLivrosPorId(idLivro);

            if (livro.ObterIdLivro() == 0)
            {
                Console.WriteLine("Livro não cadastrado");
            }
            else
            {
                Console.WriteLine($"O Livro {idLivro} que estava com a pessoa {idPessoa} foi devolvido com sucesso");
            }
        }
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

    public void ImprimirLivrosEmprestados(int id)
    {
        Pessoa pessoa = ConsultarPessoasPorId(id);
        Console.WriteLine($"Livros emprestados por {pessoa}");

        if (pessoa.ObterLivrosEmprestados().Count > 0)
        {
            foreach (var livro in pessoa.ObterLivrosEmprestados())
            {
                Console.WriteLine($"{livro} está emprestado para {pessoa}");
            }
        }
        else
        {
            Console.WriteLine($"Nennum livro emprestado para {pessoa}");
        }
    }
}