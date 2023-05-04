using Escola.Interface;

namespace Escola.Mocks
{
  public class PessoaServiceMock : IPessoasService
  {
    public void CadastrarAluno()
    {
      Console.WriteLine("Mock Cadastrar Alunos ");
    }

    public void CadastrarProfessor()
    {
      Console.WriteLine("Mock Cadastrar professor ");
    }

    public void ExibirPessoas()
    {
      Console.WriteLine("Mock Exibir Pessoas ");
    }

    public void FiltroPorNome(string nome)
    {
      Console.WriteLine("Mock Filtro Por nome ");
    }
  }
}