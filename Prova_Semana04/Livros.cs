using System.Collections;

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

    public int? EmprestarLivro(int quantidadeEmprestada)
    {
        Livros livros = new Livros();
        
        Pessoa pessoa = new Pessoa();
        
        Console.WriteLine("Digite o ID do Aluno");
        
        foreach (int idAlunos in pessoa.Id)
            if (idAlunos == livros.Id)
            {
                Console.WriteLine("Pessoa já cadastrada");
            }
            else
            {
                livros.Id = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o ID do livro");
                
                foreach (int idLivros in livros.Id)
                    if (idLivros == livros.Id) 
                    {
                        livros.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O Livro {livros.Titulo} foi emprestado para " +
                                          $"a pessoa {pessoa.Nome}");
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("Livro não cadastrado");
                        return 0;
                    }
            }

        return null;
    }

    public int? DevolverLivro(int quantidadeDevolvida)
    {
        Livros livros = new Livros();
        Pessoa pessoa = new Pessoa();
        
        Console.WriteLine("Digite o ID do Aluno");
        
        foreach (int idAlunos in livros.Id)
            if (idAlunos == livros.Id)
            {
                Console.WriteLine("Pessoa já cadastrada");
            }
            else
            {
                livros.Id = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o ID do livro");
                
                foreach (int idLivros in livros.Id)
                    if (idLivros == livros.Id) 
                    {
                        livros.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O Livro {livros.Titulo} que estava com a pessoa {pessoa.Nome} "+
                            $"foi devolvido com sucesso”");
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("Livro não cadastrado");
                        return 0;
                    }
            }

        return null;
    }
}