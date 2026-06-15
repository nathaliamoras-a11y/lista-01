Console.WriteLine("Informe a primeira pontuação:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda pontuação:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a terceira pontuação:");
int num3 = int.Parse(Console.ReadLine());

if (num1 == num2 && num2 == num3)
{
    Console.WriteLine("As três pontuações são iguais.");
}
else if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine("Maior pontuação: " + num1);
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.WriteLine("Maior pontuação: " + num2);
}
else
{
    Console.WriteLine("Maior pontuação: " + num3);
}

