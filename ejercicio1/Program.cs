// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce un numero");
Decimal num1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Introduce otro numero");
Decimal num2 = Convert.ToDecimal(Console.ReadLine());
Decimal resta=Math.Abs(num1-num2);
if(num1>num2){
    Console.WriteLine("El resultado de la resta es: {0}",resta*2);
}else{
    Console.WriteLine("El resultado de la resta es: {0}",resta);
}