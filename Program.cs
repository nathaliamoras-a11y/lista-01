Console.WriteLine("Informe a quantidade de clientes atendidos:");
int quantidade = int.Parse(Console.ReadLine());

int total = 0;

for (int i = 1; i <= quantidade; i++)
{
    Console.WriteLine("Informe o tempo do atendimento:");
    int tempo = int.Parse(Console.ReadLine());

    total += tempo;
}

double media = (double)total / quantidade;

Console.WriteLine("Tempo total de atendimento: " + total + " minutos");
Console.WriteLine("Tempo médio por cliente: " + media + " minutos");