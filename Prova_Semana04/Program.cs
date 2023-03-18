using System;

namespace Prova_Semana04 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Cadastrar Pessoa " +
                              "2 - Cadastrar Livro" +
                              "3 - Emprestar Livro" +
                              "4 - Devolver Livro" +
                              "5 - Listar todos os livros" +
                              "6 - Listar todas as pessoas cadastradas" +
                              "7 - Listar todos os livros emprestados");
            
            int menu = int.Parse(Console.ReadLine()!);

            bool retornarMenu = false; //Usado para voltar ao menu, já que o Switch não fornece essa opção por padrão
            
            while (!retornarMenu)
            {
                switch (menu)
                {
                    case 1:
                        Pessoa pessoa = new Pessoa();

                        Console.WriteLine("Digite o ID: ");
                        Console.ReadLine();
                        
                        foreach (var identificacao in pessoa.Id)
                        {
                            if (identificacao == pessoa.Id)
                            {
                                pessoa.Id = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                               Console.WriteLine("Pessoa já cadastrada");
                               retornarMenu = true;
                            }
                        }

                        Console.WriteLine("Digite o Nome: ");
                        pessoa.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o CPF: ");
                        pessoa.Cpf = Console.ReadLine();

                        Console.WriteLine("Digite o telefone: ");
                        pessoa.Telefone = Console.ReadLine();

                        Console.WriteLine("Digite o ID: ");
                        pessoa.Id = int.Parse(Console.ReadLine());

                        retornarMenu = true;
                        
                        break;

                    case 2:
                        Livros livro = new Livros();

                        Console.WriteLine("Digite o ID: ");
                        livro.Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o Título: ");
                        livro.Titulo = Console.ReadLine();

                        Console.WriteLine("Digite o autor: ");
                        livro.Autor = Console.ReadLine();

                        Console.WriteLine("Digite a editora: ");
                        livro.Editora = Console.ReadLine();

                        Console.WriteLine("Digite a quantidade de exemplares: ");
                        livro.QuantidadeExemplares = int.Parse(Console.ReadLine());

                        retornarMenu = true;
                        
                        break;

                    case 3:
                        //Emprestar Livro
                        retornarMenu = true;
                        break;

                    case 4:
                        //Devolver Livro
                        retornarMenu = true;
                        break;

                    case 5:
                        //Listar todos os livros
                        retornarMenu = true;
                        break;

                    case 6:
                        //Listar todas as pessoas cadastradas
                        retornarMenu = true;
                        break;

                    case 7:
                        //Listar todos os livros emprestados
                        retornarMenu = true;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        retornarMenu = true;
                        break;
                }
            }
        }
    }
}