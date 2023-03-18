using System;

namespace Prova_Semana04;

public class Pessoa
{
    //Atributos
    public Pessoa(int id, string nome, string cpf, string telefone, List<Livros> livrosEmprestados)
    {
        Id = id;
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        LivrosEmprestados = livrosEmprestados;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public List<Livros> LivrosEmprestados { get; set; }
    
    //Métodos
    //AdicionarLivroLista(Livro)
    //RemoverLivroLista(int idLivro)

    public int AdicionarLivroLista(int Livro)
    {
        LivrosEmprestados.Add();
        return Livro;
    }
    
    public int RemoverLivroLista(int idLivro)
    {
        LivrosEmprestados.Remove();
        return idLivro;
    }
}