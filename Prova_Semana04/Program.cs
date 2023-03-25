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
        int menu = 0;
        do
        {
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Cadastrar Pessoa " +
                              "\n2 - Cadastrar Livro" +
                              "\n3 - Emprestar Livro" +
                              "\n4 - Devolver Livro" +
                              "\n5 - Listar todos os livros" +
                              "\n6 - Listar todas as pessoas cadastradas" +
                              "\n7 - Listar todos os livros emprestados");


            menu = int.Parse(Console.ReadLine());

            Biblioteca biblioteca = new Biblioteca(new List<Pessoa>(), new List<Livros>());
            
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Digite o ID da pessoa: ");
                    int id = int.Parse(Console.ReadLine());

                    if (biblioteca.ConsultarPessoasPorId(id) != null)
                    {
                        Console.WriteLine("Pessoa já cadastrada");
                        break;
                    }
                    else
                    {

                        Console.WriteLine("Digite o nome da pessoa: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF da pessoa: ");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Digite o telefone da pessoa: ");
                        string telefone = Console.ReadLine();

                        Pessoa pessoa = new Pessoa(id, nome, cpf, telefone);
                        biblioteca.CadastrarPessoa(pessoa);
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    Console.WriteLine("Digite o ID do livro: ");
                    int idLivro = int.Parse(Console.ReadLine());

                    if (biblioteca.ConsultarLivrosPorId(idLivro) != null)
                    {
                        Console.WriteLine("Livro já cadastrado");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite o nome do livro: ");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Digite o autor do livro: ");
                        string autor = Console.ReadLine();
                        Console.WriteLine("Digite a editora do livro: ");
                        string editora = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade de exemplares");
                        int quantidadeExemplares = int.Parse(Console.ReadLine());

                        Livros livro = new Livros(idLivro, titulo, autor, editora, quantidadeExemplares);
                        livro.EmprestarLivro(quantidadeExemplares);
                        biblioteca.CadastrarLivro(livro);
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    Console.WriteLine("\nDigite o id da pessoa: ");
                    int id_Pessoa = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o id do livro: ");
                    int id_Livro = int.Parse(Console.ReadLine());
                    biblioteca.EmprestarLivroBiblioteca(id_Pessoa, id_Livro);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("\nDigite o id da pessoa: ");
                    int idPessoas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o id do livro: ");
                    int idLivros = int.Parse(Console.ReadLine());
                    biblioteca.DevolverLivroBiblioteca(idPessoas, idLivros);
                    Console.WriteLine("\n");
                    Console.ReadKey();
                    break;
                case 5:
                    biblioteca.ImprimirRelatorioLivros();
                    Console.ReadKey();
                    break;
                case 6:
                    biblioteca.ImprimirRelatorioPessoas();
                    Console.ReadKey();
                    break;
                case 7:
                    biblioteca.ImprimirLivrosEmprestados();
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        } while (menu > 0 && menu < 8);
    }

}
