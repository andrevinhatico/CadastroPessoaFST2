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

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

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

            PessoaFisica metodoPf = new PessoaFisica();
            string? opcaopf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=============================================
|       Escolha uma das opções abaixo       |
|-------------------------------------------|
|         1 - Cadastrar Pessoa Física       |
|         2 - Listar Pessoas Fisica         |
|                                           |
|         0 - Voltar ao menu anterior       |
=============================================
");

                opcaopf = Console.ReadLine();


                switch (opcaopf)
                {
                    case "1":
                        Console.Clear();
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa que deseja cadastrar");
                        novaPf.Nome = Console.ReadLine();

                        bool dataValida;

                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex: DD/MM/AAAA");
                            string? dataNasc = Console.ReadLine();
                            dataValida = metodoPf.ValidarDataNasc(dataNasc);

                            if (dataValida)
                            {
                                novaPf.DataNasc = dataNasc;
                            }
                            else
                            {
                                Console.WriteLine($"Data digitada inválida!");

                            }

                        } while (!dataValida);

                        Console.WriteLine($"Digite o CPF");
                        novaPf.Cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEnd.Logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero");
                        novoEnd.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento");
                        novoEnd.Complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEnd.EndComercial = true;
                        }
                        else
                        {
                            novoEnd.EndComercial = false;
                        }

                        novaPf.Endereco = novoEnd;

                        listaPf.Add(novaPf);

                        //StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt");
                        //sw.WriteLine(novaPf.Nome);
                        //sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt"))
                        {
                            sw.WriteLine(novaPf.Nome);
                        }

                        Console.Clear();
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Thread.Sleep(3000);

                        break;

                    case "2":
                        Console.Clear();

                        //                         if (listaPf.Count > 0)
                        //                         {
                        //                             foreach (PessoaFisica cadaPessoa in listaPf)
                        //                             {
                        //                                 Console.WriteLine(@$"
                        // Nome: {cadaPessoa.Nome}
                        // Data de Nascimento: {cadaPessoa.DataNasc}
                        // CPF: {cadaPessoa.Cpf}
                        // Endereço: {cadaPessoa.Endereco.Logradouro}, {cadaPessoa.Endereco.Numero}, {cadaPessoa.Endereco.Complemento}
                        // Rendimento: {cadaPessoa.Rendimento.ToString("C")}
                        // Taxa de Imposto a ser pago é: {metodoPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")}
                        // Maior de idade: {(metodoPf.ValidarDataNasc(cadaPessoa.DataNasc) ? "Sim" : "Não")} 
                        // Idade: {metodoPf.ValidarIdade(cadaPessoa.DataNasc)} anos 
                        //             ");
                        //                                 Console.WriteLine();
                        //                                 Console.WriteLine($"Aperte 'ENTER' para continuar");
                        //                                 Console.ReadLine();

                        //                             }
                        //                         }
                        //                         else
                        //                         {
                        //                             Console.WriteLine($"Lista Vazia");
                        //                             Thread.Sleep(3000);

                        //                         }

                        using (StreamReader sr = new StreamReader("André Ribeiro.txt"))
                        {
                            string? linha;

                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");

                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Aperte 'ENTER' para continuar");
                        Console.ReadLine();
                        break;

                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida ! Favor digitar outra opção!");
                        Thread.Sleep(3000);
                        break;
                }


            } while (opcaopf != "0");

            break;

        case "2":

            PessoaJuridica metodopj = new PessoaJuridica();
            string opcaopj;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=============================================
|       Escolha uma das opções abaixo       |
|-------------------------------------------|
|         1 - Cadastrar Pessoa Juridica     |
|         2 - Listar Pessoas Juridica       |
|                                           |
|         0 - Voltar ao menu anterior       |
=============================================
");

                opcaopj = Console.ReadLine();


                switch (opcaopj)
                {
                    case "1":
                        Console.Clear();
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco endPj = new Endereco();

                        Console.WriteLine($"Digite o nome da empesa");
                        novaPj.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite a razão social");
                        novaPj.RazaoSocial = Console.ReadLine();

                        bool cnpjTeste;
                        do
                        {
                            Console.WriteLine($"Digite a CNPJ Ex. 00.000.000/0001-00 ");
                            string? cnpj = Console.ReadLine();
                            cnpjTeste = metodopj.ValidarCNPJ(cnpj);

                            if (cnpjTeste)
                            {
                                novaPj.Cnpj = cnpj;

                            }
                            else
                            {
                                Console.WriteLine($"CNPJ digitado inválido!");
                            }

                        } while (!cnpjTeste);

                        Console.WriteLine($"Digite o rendimento mensal");
                        novaPj.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        endPj.Logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero");
                        endPj.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento");
                        endPj.Complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            endPj.EndComercial = true;
                        }
                        else
                        {
                            endPj.EndComercial = false;
                        }

                        novaPj.Endereco = endPj;
                        listaPj.Add(novaPj);

                        Console.Clear();
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Thread.Sleep(3000);

                        break;
                    case "2":
                        Console.Clear();

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPj in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {cadaPj.Nome}
Razão Social: {cadaPj.RazaoSocial}
CNPJ: {cadaPj.Cnpj}
CNPJ Válido: {(metodopj.ValidarCNPJ(cadaPj.Cnpj) ? "Sim" : "Não")}
Rendimento: {cadaPj.Rendimento.ToString("C")}
Taxa de Imposto a ser pago é: {metodopj.PagarImposto(cadaPj.Rendimento).ToString("C")}
Endereço: {cadaPj.Endereco.Logradouro}, {cadaPj.Endereco.Numero}, {cadaPj.Endereco.Complemento}
            ");

                                Console.WriteLine();
                                Console.WriteLine($"Aperte 'ENTER' para continuar");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista Vazia");
                            Thread.Sleep(3000);
                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida ! Favor digitar outra opção!");
                        Thread.Sleep(3000);
                        break;
                }




            } while (opcaopj != "0");



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
