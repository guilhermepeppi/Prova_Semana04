namespace Prova_Semana04;

public class Livros
{
    //Atributos
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

