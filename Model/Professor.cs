
namespace Escola.Model
{
     public class Professor : Pessoa
    {
        public string Especialidade { get; set; }
        public Professor(){}
        public Professor(string nome, string endereco, string telefone, string especialidade )
                            : base( nome, endereco, telefone)
        {
            Especialidade = especialidade;
        }
        public override string ConverterTexto(){
            return $"{base.ConverterTexto()}, Especialidade {Especialidade}";
        }
        public override string ToString(){
            return $"{base.ToString()},  Especialidade {Especialidade}";
        }
    }
}