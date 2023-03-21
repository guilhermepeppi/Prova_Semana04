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
    public void CadastrarPessoa(Pessoa pessoa)
    {
        string nome, cpf, telefone;
        int id = 0;

        // Solicitando dados de entrada
        Console.WriteLine("Digite o ID: ");
        Console.ReadLine();

        foreach (int idPessoa in id)
        {
            if (idPessoa == id)
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
                Pessoa pessoas = new Pessoa(id++, nome, cpf, telefone);

                // Instanciando a biblioteca para guardar o livro
                Biblioteca biblioteca = new Biblioteca();
                biblioteca.CadastrarPessoa(pessoas);
            }
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

        foreach (int idLivro in )
        {
            if (idLivro == id)
            {
                Console.WriteLine("Pessoa já cadastrada");
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

    }


    //EmprestarLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método EmprestarLivro do objeto Livro
    // e Adicionar um Livro na lista LivrosEmprestados do objeto Pessoa através do método AdicionarLivroLista;
    public int EmprestarLivroBiblioteca(int idLivro, int idPessoa)
    {
        return 0;
    }


    //DevolverLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método DevolverLivro do
    // objeto Livro e Remover um Livro na lista LivrosEmprestados do objeto Pessoa através
    // do método RemoverLivroLista;
    public int DevolverLivroBiblioteca(int idLivro, int idPessoa)
    {

        return 0;
    }

}