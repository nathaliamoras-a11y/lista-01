Console.WriteLine("Informe o saldo inicial:");
double saldo = double.Parse(Console.ReadLine());

int opcao;

do
{
    Console.WriteLine("Escolha a operação:");
    Console.WriteLine("1 - Entrada de dinheiro");
    Console.WriteLine("2 - Saída de dinheiro");
    Console.WriteLine("3 - Encerrar");

    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine("Informe o valor da movimentação:");
        double valor = double.Parse(Console.ReadLine());

        saldo += valor;

        Console.WriteLine("Entrada registrada. Saldo atual: R$ " + saldo);
    }
    else if (opcao == 2)
    {
        Console.WriteLine("Informe o valor da movimentação:");
        double valor = double.Parse(Console.ReadLine());

        if (valor <= saldo)
        {
            saldo -= valor;

            Console.WriteLine("Saída registrada. Saldo atual: R$ " + saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

} while (opcao != 3);

Console.WriteLine("Saldo final: R$ " + saldo);