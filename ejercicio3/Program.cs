using sesion;
rectangle r1=new rectangle();
Console.WriteLine("Nombre");
r1.name=Console.ReadLine();
Console.WriteLine("Ancho");
r1.width=double.Parse(Console.ReadLine());
Console.WriteLine("Alto");
r1.height=double.Parse(Console.ReadLine());
r1.printdata();