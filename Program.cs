double soma = 0;

Console.WriteLine("Informe o primeiro valor:");
soma += double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo valor:");
soma += double.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro valor:");
soma += double.Parse(Console.ReadLine());

Console.WriteLine("Informe o quarto valor:");
soma += double.Parse(Console.ReadLine());

Console.WriteLine("Informe o quinto valor:");
soma += double.Parse(Console.ReadLine());

double media = soma / 5;

Console.WriteLine("Soma dos valores: " + soma);
Console.WriteLine("Média dos valores: " + media);