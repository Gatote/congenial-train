class Program
{
    static void Main(string[] args)
    {
        int numero1 = 10;
        int numero2 = 20;
        Console.WriteLine($"Antes del intercambio: numero1 = {numero1}, numero2 = {numero2}");
        Intercambiar(ref numero1, ref numero2);
        Console.WriteLine($"Después del intercambio: numero1 = {numero1}, numero2 = {numero2}");
    }
    static void Intercambiar(ref int numero1, ref int numero2)
    {   
        int temporal = numero1;
        numero1 = numero2;
        numero2 = temporal;
    }
}
