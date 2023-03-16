string texto = "Esta es una cadena de texto con algunos espacios.";
int cantidadEspacios = cuantosespacio(texto);
Console.WriteLine($"La cantidad de espacios en la cadena es: {cantidadEspacios}");
static int cuantosespacio(string texto)
{
    int cantidadEspacios = 0;
    foreach (char caracter in texto)
    {
        if (caracter == ' ')
        {
            cantidadEspacios++;
        }
    }
    return cantidadEspacios;
}