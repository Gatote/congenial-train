double radio=10;
double circunferencia = calcularcircunferencia(radio);
Console.WriteLine($"La circunferencia de un círculo con radio {radio} es: {circunferencia}");
static double calcularcircunferencia(double radio)
{
    double circunferencia = 2 * Math.PI * radio;
    return circunferencia;
}