using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Semana04;

internal class Pessoa
{

    public Pessoa(int id, string nome, string cpf, string telefone)
    {
        Id = id;
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
    }

    //Atributos
    private int Id { get; set; }
    private string Nome { get; set; }
    private string Cpf { get; set; }
    private string Telefone { get; set; }
    private List<Livros> LivrosEmprestados { get; set; }

    

    public void AlterarNomePessoa(string novoNome)
    {
        Nome = novoNome;
    }

    public void AlterarCpf(string novoCpf)
    {
        Cpf = novoCpf;
    }

    public void AlterarTelefone(string novoTelefone)
    {
        Telefone = novoTelefone;
    }

    public string ObterNomePessoa()
    {
        return Nome;
    }

    public int ObterIdPessoa()
    {
        return Id;
    }

    public void ObterLivrosEmprestados()
    {
        List<Livros> livrosEmprestadosId = new List<Livros>(LivrosEmprestados);
    }

    public void AdicionarLivroLista(Livros livros)
    {
       
    }

    public int RemoverLivroLista(int idLivro)
    {
        return 0;
    }


    
}