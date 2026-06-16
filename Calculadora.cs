public class Calculadora 
{
    public int Somar(int a, int b)
    {
        return a + b;
    }
     public int Subtrair(int a, int b)
    {
        return a - b;
    }
    public int Multiplicar(int a, int b)
    {
         return a * b;
    }
    public int Dividir(int a, int b)
    {
         return a / b;
    }
    public double Delta(double a, double b, double c)
    {
        return Math.Pow(b, 2.0) - (4.0 * a * c);
    }
    public double BaskharaX1(double a, double b, double delta)
    {
        return ((b * -1.0) + Math.Sqrt(delta)) / (2.0 * a);
    }
    public double BaskharaX2(double a, double b, double delta)
    {
        return ((b * -1.0) - Math.Sqrt(delta)) / (2.0 * a);
    }
}