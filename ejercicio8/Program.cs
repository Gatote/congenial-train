Console.WriteLine("Ingrese números separados por un espacio:");
string input = Console.ReadLine();
string separador=" ";
string[] numbers = input.Split(separador);
int[] array = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++) {
    array[i] = int.Parse(numbers[i]);
}
int total=array.Length;
int total_ordenados=0;
while (total_ordenados<array.Length-1){
    for (int i = 0; i < array.Length; i++) {
        if (i<array.Length-1){
            if (array[i]>array[i+1]){
                int ntemp=array[i];
                array[i]=array[i+1];
                array[i+1]=ntemp;
                total_ordenados=0;
            }
            else{
                total_ordenados=total_ordenados+1;
            }
        }
    }
}

Console.WriteLine("\n{0}\n",String.Join(separador, array));