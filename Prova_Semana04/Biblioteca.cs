using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Semana04;

internal class Biblioteca
{
    public Biblioteca(List<Pessoa> pessoas, List<Livros> livros)
    {
        Pessoas = pessoas;
        Livros = livros;
    }

    //Atributos
    private List<Pessoa> Pessoas { get; set; }
    private List<Livros> Livros { get; set; }


    //Métodos:


    public void CadastrarPessoa(Pessoa pessoas)
    {
        if (Pessoas == null)
            Pessoas = new List<Pessoa>();
        Pessoas.Add(pessoas);
    }



    public void CadastrarLivro(Livros livros)
    {
        if (Livros == null)
            Livros = new List<Livros>();
        Livros.Add(livros);
    }



    public void EmprestarLivroBiblioteca(int idLivro, int idPessoa)
    {
        //FALTA CHAMAR O MÉTODO EMPRESTARLIVRO


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
        foreach (Pessoa pessoa in Pessoas)
        {
            Console.WriteLine($"Nome: {pessoa.ObterNomePessoa()}");
        }
    }

    public void ImprimirLivrosEmprestados()
    {
        //  Listar todos os livros emprestados
        // Percorrer a lista livrosemprestados da classe Pessoa e então os imprimir na tela da seguinte forma: “{Nome do Livro} está emprestado para {nome da pessoa}”, se não houver livros emprestados, imprimir a mensagem “Não há livros emprestados”.

        foreach (Pessoa pessoa in Pessoas)
        {
            if (pessoa.ObterLivrosEmprestados().Count == 0)
            {
                Console.WriteLine("Não há livros emprestados");
            }
            else
            {
                foreach (Livros livro in pessoa.ObterLivrosEmprestados())
                {
                    Console.WriteLine($"O livro {livro.ObterNomeLivro()} está emprestado para {pessoa.ObterNomePessoa()}");
                }
            }

        }


    }
}