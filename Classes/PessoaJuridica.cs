using CadastroPessoaFST2.Interfaces;

namespace CadastroPessoaFST2.Classes
{
    public class PessoaJuridica : Pessoa , IPessoaJuridica
    {
        public string? Cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCNPJ(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}