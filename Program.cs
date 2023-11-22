using System.ComponentModel;

Console.WriteLine("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

Console.WriteLine("Digite sua Data de Nascimento no formato dd/mm/aa: ");
DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);

Console.WriteLine("Digite seu CPF sem ponto: ");
int.TryParse(Console.ReadLine(), out int cpf);

Console.WriteLine("Digite seu peso: ");
decimal.TryParse(Console.ReadLine(), out decimal peso);

Console.WriteLine("Digite sua altura: ");
decimal.TryParse(Console.ReadLine(), out decimal altura);

Pessoa p = new Pessoa (nome, sobrenome, dataNascimento, cpf, peso, altura);

int idade = p.CalculaIdade();

decimal imc = Math.Round(p.CalcularIMC(),2);

bool sair = false;

while(!sair)
{
    Console.WriteLine("Esolha uma das opções abaixo!");
    Console.WriteLine("0 - Informações dos usuário");
    Console.WriteLine("1 - Calcular IMC");
    Console.WriteLine("2 - Verificar a maioridade do usuário");
    Console.WriteLine("3 - Sair");

    string? opcao = Console.ReadLine();

switch(opcao)
{
    case "0":
    Console.WriteLine($"Nome completo: {nome} {sobrenome}");
    Console.WriteLine($"CPF: {cpf}");
    Console.WriteLine($"Data de nascimento: {dataNascimento}");
    Console.WriteLine($"Altura: {altura}");
    Console.WriteLine($"Peso: {peso}");
    Console.WriteLine($"Idade: {idade}");
    break;

    case "1":

    if(imc <= 16) 
    {
        Console.WriteLine("Muito abaixo do peso");
    }
    else if (imc >= 17 && imc <= 18)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else if (imc >= 18 && imc <= 25)
    {
        Console.WriteLine("Peso normal");
    }
    else if (imc >= 26 && imc <= 29)
    {
        Console.WriteLine("Acima do peso");
    }
    else if (imc >= 30 && imc <= 35)
    {
        Console.WriteLine("Obesidade grau 1");
    }
    else if (imc >= 35 && imc <= 40)
    {
        Console.WriteLine("Obesidade grau 2");
    }
    else if (imc >= 40)
    {
        Console.WriteLine("Obesidade grau 3");
    }

    break;
    case "2":
    if(idade >= 18)
    {
        Console.WriteLine("Maior de idade :)");
    }

    else
    {
        Console.WriteLine("Menor de idade ;)");
    }
    break;

    case "3":
    sair = true;
    break;
}
}