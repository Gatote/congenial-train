List<string> palabras = new List<string>{"hola", "mundo", "programacionx", "c#x", "openai"};
char letra = 'x';
int cantidadPalabras = cuantasx(palabras, letra);
Console.WriteLine($"La cantidad de palabras que contienen la letra '{letra}' es: {cantidadPalabras}");

static int cuantasx(List<string> palabras, char letra)
{
    int cantidadPalabras = 0;

    foreach (string palabra in palabras)
    {
        if (palabra.Contains(letra))
        {
            cantidadPalabras++;
        }
    }

    return cantidadPalabras;
}