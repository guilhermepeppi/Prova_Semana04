namespace Prova_Semana04
{
    internal interface IBiblioteca
    {
        void CadastrarLivro(Livros livros);
        void CadastrarPessoa(Pessoa Pessoa);
        int DevolverLivroBiblioteca(int idLivro, int idPessoa);
        int EmprestarLivroBiblioteca(int idLivro, int idPessoa);
    }
}