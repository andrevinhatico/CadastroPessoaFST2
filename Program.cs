using CadastroPessoaFST2.Classes;

Console.Clear();

Console.WriteLine(@$"
=================================================
|     Bem Vindo ao Sistema de Cadastro          |
|       Pessoas Físicas e Jurídicas             |
=================================================
");

Util.BarraCarregamento("Carregando", 500);


string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================
|       Escolha uma das opções abaixo       |
|-------------------------------------------|
|         1 - Pessoa Física                 |
|         2 - Pessoa Jurídica               |
|                                           |
|         0 - Sair                          |
=============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodoPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novaPf.Nome = "Andre";
            novaPf.DataNasc = new DateTime(2000, 01, 01);
            novaPf.Cpf = "1234567890";
            novaPf.Rendimento = 10000.5f;

            novoEnd.Logradouro = "Avenida Bora Baea";
            novoEnd.Numero = 5988;
            novoEnd.Complemento = "Cidade Tricolor";
            novoEnd.EndComercial = true;

            novaPf.Endereco = novoEnd;

            // Console.WriteLine($"Nome: {novaPf.Nome}");
            // Console.WriteLine($"Data de Nascimento: {novaPf.DataNasc}");
            // Console.WriteLine($"CPF: {novaPf.Cpf}");
            // Console.WriteLine($"Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}, {novaPf.Endereco.Complemento}");

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.Nome}
Data de Nascimento: {novaPf.DataNasc}
CPF: {novaPf.Cpf}
Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}, {novaPf.Endereco.Complemento}
            ");

            Console.WriteLine($"{metodoPf.ValidarDataNasc(novaPf.DataNasc)}");

            // Console.WriteLine($"{novaPf.ValidarDataNasc(new DateTime(2012,01,01))}");

            Console.WriteLine();
            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();
            

            break;

        case "2":
            PessoaJuridica metodopj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco endPj = new Endereco();

            novaPj.Nome = "Nome Pj";
            novaPj.RazaoSocial = "Razao Social PJ";
            novaPj.Cnpj = "00.000.000/0001-00";
            novaPj.Rendimento = 10000.5f;

            endPj.Logradouro = "Avenida PJ";
            endPj.Numero = 218;
            endPj.Complemento = "Rua Nova";
            endPj.EndComercial = true;

            novaPj.Endereco = endPj;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}
CNPJ Válido: {metodopj.ValidarCNPJ(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.Logradouro}, {novaPj.Endereco.Numero}, {novaPj.Endereco.Complemento}
            ");

            // Console.WriteLine(metodopj.ValidarCNPJ("00.000.000/0001-00"));

            Console.WriteLine();
            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por ultilizar Sistema 1.0!");

            Util.BarraCarregamento("Finalizando", 300);

            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida ! Favor digitar outra opção!");
            Thread.Sleep(3000);
            
            break;
    }
} while (opcao != "0");


// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.Nome);

// Console.WriteLine($"Nome: {novaPf.Nome} Rendimento: {novaPf.Rendimento}");
// Console.WriteLine("Nome: " + novaPf.Nome + " Rendimento: " + novaPf.Rendimento);
