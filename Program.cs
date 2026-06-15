Console.WriteLine("Informe o número inicial da contagem regressiva:");
int numero = int.Parse(Console.ReadLine());

for (int i = numero; i >= 0; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("Fim da contagem.");