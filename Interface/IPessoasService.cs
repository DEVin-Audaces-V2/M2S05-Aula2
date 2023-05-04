
namespace Escola.Interface
{
    public interface IPessoasService
    {
        public void FiltroPorNome(string nome);
        public void ExibirPessoas();
        public void CadastrarAluno();
        public void CadastrarProfessor();
    }
}