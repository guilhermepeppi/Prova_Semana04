using System;


namespace Prova_Semana04;

public class Livros
{
    //Atributos
    public Livros(int id, string titulo, string autor, string editora, int quantidadeExemplares)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        Editora = editora;
        QuantidadeExemplares = quantidadeExemplares;
    }

    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Editora { get; set; }
    public int QuantidadeExemplares { get; set; }
    
   // Métodos
   // EmprestarLivro(int quantidadeEmprestada) - Deverá decrementar a QuantidadeExemplares do livro ;
   // DevolverLivro(int quantidadeDevolvida) - Deverá incrementar a QuantidadeExemplares do livro;

   public int EmprestarLivro(int quantidadeEmprestada)
   {
       int quantidadeEmprestadaDeLivros;
       quantidadeEmprestadaDeLivros -= 1;
       return quantidadeEmprestadaDeLivros;

   }
   
   public int DevolverLivro(int quantidadeDevolvida)
   {
       int quantidadeEmprestadaDeLivros;
       quantidadeEmprestadaDeLivros += 1;
       return quantidadeEmprestadaDeLivros;
   }
   
}