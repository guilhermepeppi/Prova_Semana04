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
        Pessoa pessoa = ConsultarPessoasPorId(idPessoa);
        Livros livro = ConsultarLivrosPorId(idLivro);

        if (pessoa != null)
        {
            if (livro != null)
            {
                pessoa.AdicionarLivroLista(livro);
                livro.EmprestarLivro(idPessoa);
                Console.WriteLine($"\nO Livro {idLivro} foi emprestado para a pessoa {idPessoa}");
            }
            else
            {
                Console.WriteLine("\nLivro não cadastrado");
            }
        }
        else
        {
            Console.WriteLine("\nPessoa não cadastrada");
        }
    }

    public void DevolverLivroBiblioteca(int idLivro, int idPessoa)
    {
        Pessoa pessoa = ConsultarPessoasPorId(idPessoa);
        Livros livro = ConsultarLivrosPorId(idLivro);

        if (pessoa != null)
        {
            if (livro != null)
            {
                pessoa.RemoverLivroLista(idLivro);
                livro.EmprestarLivro(0);
                Console.WriteLine($"\nO Livro {idLivro} que estava com a pessoa {idPessoa} foi devolvido com sucesso");
            }
            else
            {
                Console.WriteLine("\nLivro não cadastrado");
            }
        }
        else
        {
            Console.WriteLine("\nPessoa não cadastrada");
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
                Console.WriteLine($"\nLivro: {livro.ObterNomeLivro()} Autor: {livro.ObterAutorLivro()}");
            }
        }
        else
        {
            Console.WriteLine("\nNão há livros cadastrados");
        }
    }

    public void ImprimirRelatorioPessoas()
    {
        if (Pessoas.Count > 0)
        {
            foreach (Pessoa pessoa in Pessoas)
            {
                Console.WriteLine($"\nPessoa: {pessoa.ObterNomePessoa()}");
            }
        }
        else
        {
            Console.WriteLine("\nNão há pessoas cadastradas");
        }
    }

    public void ImprimirLivrosEmprestados()
    {
        if (Pessoas.Count > 0)
        {
            foreach (Pessoa pessoa in Pessoas)
            {
                Console.WriteLine($"Pessoa: {pessoa.ObterNomePessoa()}");
                foreach (Livros livro in pessoa.ObterLivrosEmprestados())
                {
                    Console.WriteLine($"L\nivro: {livro.ObterNomeLivro()} Autor: {livro.ObterAutorLivro()}");
                }
            }
        }
        else
        {
            Console.WriteLine("\nNão há livros cadastradas");
        }

    }


}