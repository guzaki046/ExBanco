using System.Globalization;
using ExBanco;

double quantia = 0.0;

Console.Write("Entre o número da conta: ");
int numero = int.Parse(Console.ReadLine());


Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();

ContaBancaria conta;

Console.Write("Haverá depósito inicial (s/n)? ");
char resposta = char.Parse(Console.ReadLine());

if (resposta == 's' || resposta == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, depositoInicial);
}
else
    conta = new ContaBancaria(numero, titular);

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Depositar(quantia);

Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para saque: "); 
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Sacar(quantia);

Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);
