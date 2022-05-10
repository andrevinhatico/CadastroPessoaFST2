using System.Text.RegularExpressions;
using CadastroPessoaFST2.Interfaces;

namespace CadastroPessoaFST2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }

        public string? RazaoSocial { get; set; }

        public string? Caminho { get; private set; } = "Database/PessoaJuridica.csv";



        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;
            }
            else if (rendimento <= 6000)
            {
                return rendimento * .05f;
            }
            else if (rendimento <= 10000)
            {
                return rendimento * 0.7f;
            }
            else
            {
                return rendimento * .09f;
            }

        }

        //XX.XXX.XXX/0001-XX --- XXXXXXXX0001XX
        public bool ValidarCNPJ(string cnpj)
        {

            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }

                }
                else if (cnpj.Length == 14)

                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void Inserir(PessoaJuridica pj)
        {

            VerificarPastaArquivo(Caminho);

            string[] pjString = { $"{pj.Nome},{pj.Cnpj},{pj.RazaoSocial}" };

            File.AppendAllLines(Caminho, pjString);

        }

        public List<PessoaJuridica> LerArquivo()
        {

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(Caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.Cnpj = atributos[1];
                cadaPj.RazaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }

            return listaPj;

        }


    }
}