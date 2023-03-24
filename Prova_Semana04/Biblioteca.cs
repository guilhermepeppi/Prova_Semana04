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
                pessoa.AdicionarLivroLista(livro);
                livro.EmprestarLivro(1);

            }
        }
    }

    //DevolverLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método DevolverLivro do
    // objeto Livro e Remover um Livro na lista LivrosEmprestados do objeto Pessoa através
    // do método RemoverLivroLista;
    public void DevolverLivroBiblioteca(int idLivro, int idPessoa)
    {
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
                pessoa.RemoverLivroLista(idLivro);
                livro.DevolverLivro(1);
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
        if (Livros.Count > 0)
        {
            foreach (Livros livro in Livros)
            {
                Console.WriteLine($"Livro: {livro.ObterNomeLivro()} Autor: {livro.ObterAutorLivro()}");
            }
        }
        else
        {
            Console.WriteLine("Não há livros cadastrados");
        }
    }

    public void ImprimirRelatorioPessoas()
    {
        if (Pessoas.Count > 0)
        {
            foreach (Pessoa pessoa in Pessoas)
            {
                Console.WriteLine($"Pessoa: {pessoa.ObterNomePessoa()}");
            }
        }
        else
        {
            Console.WriteLine("Não há pessoas cadastradas");
        }
    }

    public void ImprimirLivrosEmprestados()
    {
        foreach (Pessoa pessoa in Pessoas)
        {
            if (pessoa.ObterLivrosEmprestados().Count > 0)
            {
                foreach (Livros livro in pessoa.ObterLivrosEmprestados())
                {
                    Console.WriteLine($"O livro {livro.ObterNomeLivro()} está emprestado para {pessoa.ObterNomePessoa()}");
                }
            }
            else
            {
                Console.WriteLine("Não há livros emprestados");
            }
        }

    }
}