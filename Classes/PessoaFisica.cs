using CadastroPessoaFST2.Interfaces;

namespace CadastroPessoaFST2.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica 
    {
        public string? Cpf { get; set; }

        public DateTime dataNasc { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}