using CadastroPessoaFST2.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodoPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

novaPf.nome = "Andre";
novaPf.dataNasc = new DateTime (2000,01,01);
novaPf.cpf = "1234567890";
novaPf.rendimento = 10000.5f;

novoEnd.logradouro = "Avenida Bora Baea";
novoEnd.numero = 5988;
novoEnd.complemento =  "Cidade Tricolor";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

Console.WriteLine($"Nome: {novaPf.nome}");
Console.WriteLine($"Data de Nascimento: {novaPf.dataNasc}");
Console.WriteLine($"CPF: {novaPf.cpf}");
Console.WriteLine($"Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}, {novaPf.endereco.complemento}");

Console.WriteLine(@$"
Nome: {novaPf.nome}
Data de Nascimento: {novaPf.dataNasc}
CPF: {novaPf.cpf}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}, {novaPf.endereco.complemento}
");


Console.WriteLine($"{metodoPf.ValidarDataNasc(novaPf.dataNasc)}");



// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.Nome);

// Console.WriteLine($"Nome: {novaPf.Nome} Rendimento: {novaPf.Rendimento}");
// Console.WriteLine("Nome: " + novaPf.Nome + " Rendimento: " + novaPf.Rendimento);


// Console.WriteLine($"{novaPf.ValidarDataNasc(new DateTime(2012,01,01))}");






