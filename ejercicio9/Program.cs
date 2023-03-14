using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Ingrese números separados por un espacio:");
        string input = Console.ReadLine();
        string separador=" ";
        string[] numbers = input.Split(separador);
        int[] array = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++) {
            array[i] = int.Parse(numbers[i]);
        }
        Array.Sort(array);
        Console.WriteLine("Numero buscado:");
        int n = int.Parse(Console.ReadLine());

        int resultado = busqueda(array, n);
        if (resultado == -1) {
            Console.WriteLine("El número no está en el arreglo");
        } else {
            Console.WriteLine("El número está en la posición {0}", resultado);
        }
    }

    static int busqueda(int[] array, int n) {
        int izquierda = 0;
        int derecha = array.Length - 1;
        while (izquierda <= derecha) {
            int medio = izquierda + (derecha - izquierda) / 2;
            if (array[medio] == n) {
                return medio;
            } else if (array[medio] < n) {
                izquierda = medio + 1;
            } else {
                derecha = medio - 1;
            }
        }
        return -1; // número no encontrado en el arreglo
    }

}
