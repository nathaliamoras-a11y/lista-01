double nota;

do
{
    Console.WriteLine("Informe uma nota de 0 a 10:");
    nota = double.Parse(Console.ReadLine());

    if (nota < 0 || nota > 10)
    {
        Console.WriteLine("Nota inválida. Informe novamente.");
    }

} while (nota < 0 || nota > 10);

Console.WriteLine("Nota registrada: " + nota);