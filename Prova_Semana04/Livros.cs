using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Semana04;

internal class Livros
{
    public Livros(int id, string titulo, string autor, string editora, int quantidadeExemplares)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        Editora = editora;
        QuantidadeExemplares = quantidadeExemplares;
    }

    //Atributos
    private int Id { get; set; }
    private string Titulo { get; set; }
    private string Autor { get; set; }
    private string Editora { get; set; }
    private int QuantidadeExemplares { get; set; }

    public void AlterarTituloLivro(string novoTitulo)
    {
        Titulo = novoTitulo;
    }

    public void AlterarAutorLivro(string novoAutor)
    {
        Autor = novoAutor;
    }

    public void AlterarEditora(string novaEditora)
    {
        Editora = novaEditora;
    }

    public string ObterNomeLivro()
    {
        return Titulo;
    }

    public string ObterAutorLivro()
    {
        return Autor;
    }

    public int ObterIdLivro()
    {
        return Id;
    }

    public int EmprestarLivro(int quantidadeEmprestada)
    {
        QuantidadeExemplares -= quantidadeEmprestada;
        return QuantidadeExemplares;
    }

    public int DevolverLivro(int quantidadeDevolvida)
    {
        QuantidadeExemplares += quantidadeDevolvida;
        return QuantidadeExemplares;
    }
}