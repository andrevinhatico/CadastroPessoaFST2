using CadastroPessoaFST2.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.Nome = "Andre";
novaPf.Rendimento = 10000.5f;

Console.WriteLine(novaPf.Nome);
Console.WriteLine(novaPf.Nome);

Console.WriteLine($"Nome: {novaPf.Nome} Rendimento: {novaPf.Rendimento}");
Console.WriteLine("Nome: " + novaPf.Nome + " Rendimento: " + novaPf.Rendimento);
