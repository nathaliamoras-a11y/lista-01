Console.WriteLine("Informe a idade do passageiro:");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor normal da passagem:");
double valor = double.Parse(Console.ReadLine());

double valorPagar;

if (idade <= 5)
{
    valorPagar = 0;
}
else if (idade >= 60)
{
    valorPagar = valor / 2;
}
else
{
    valorPagar = valor;
}

Console.WriteLine("Valor normal da passagem: R$ " + valor);
Console.WriteLine("Valor a pagar: R$ " + valorPagar);