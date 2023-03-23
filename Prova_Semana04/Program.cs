using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Semana04;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite a opção desejada: ");
        Console.WriteLine("1 - Cadastrar Pessoa " +
                          "\n2 - Cadastrar Livro" +
                          "\n3 - Emprestar Livro" +
                          "\n4 - Devolver Livro" +
                          "\n5 - Listar todos os livros" +
                          "\n6 - Listar todas as pessoas cadastradas" +
                          "\n7 - Listar todos os livros emprestados");

        var menu = int.Parse(Console.ReadLine()!);

        Biblioteca biblioteca = new Biblioteca();

        switch (menu)
        {
            case 1:
                //biblioteca.CadastrarPessoa();
                break;
            case 2:
                biblioteca.CadastrarLivro();
                break;
            case 3:
                biblioteca.EmprestarLivroBiblioteca();
                break;
            case 4:
                biblioteca.DevolverLivroBiblioteca();
                break;
            case 5:
                biblioteca.ImprimirRelatorioLivros();
                break;
            case 6:
                biblioteca.ImprimirRelatorioPessoas();
                break;
            case 7:
                biblioteca.ImprimirLivrosEmprestados();
                break;
            default:
                break;
        }
    }
}
