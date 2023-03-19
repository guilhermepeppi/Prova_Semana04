﻿using System;
using System.Collections.Generic;
using System.Globalization;

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
                        
                        retornarMenu = true;
                        
                        break;

                    case 2:

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