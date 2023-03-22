using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Semana04;

internal class Livros
{

    public Livros(int id, string titulo, string autor, string editora)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        Editora = editora;
    }

    //Atributos
    private int Id { get; set; }
    private string Titulo { get; set; }
    private string Autor { get; set; }
    private string Editora { get; set; }
    private int QuantidadeExemplares { get; set; }

    public void AdicionarQuantidadeEstoque(int quantidade)
    {
        QuantidadeExemplares += quantidade;
    }

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

    // Métodos
    // EmprestarLivro(int quantidadeEmprestada) - Deverá decrementar a QuantidadeExemplares do livro ;
    // DevolverLivro(int quantidadeDevolvida) - Deverá incrementar a QuantidadeExemplares do livro;

    public void EmprestarLivro(int quantidadeEmprestada)
    {
        QuantidadeExemplares += 1;
    }

    public void DevolverLivro(int quantidadeDevolvida)
    {
        QuantidadeExemplares -= 1;
    }

}
