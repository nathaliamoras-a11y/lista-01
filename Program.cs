int senha;

do
{
    Console.WriteLine("Informe a senha:");
    senha = int.Parse(Console.ReadLine());

    if (senha != 1234)
    {
        Console.WriteLine("Senha incorreta. Tente novamente.");
    }

} while (senha != 1234);

Console.WriteLine("Acesso permitido.");