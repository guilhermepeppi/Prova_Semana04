﻿using System;
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
                          "2 - Cadastrar Livro" +
                          "3 - Emprestar Livro" +
                          "4 - Devolver Livro" +
                          "5 - Listar todos os livros" +
                          "6 - Listar todas as pessoas cadastradas" +
                          "7 - Listar todos os livros emprestados");

        var menu = int.Parse(Console.ReadLine()!);

    }
}

//to do : Guilherme