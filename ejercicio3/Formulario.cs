namespace sesion;

public class rectangle
{
    public string name {get;set;}
    public double width {get;set;}
    public double height  {get;set;}
    public void printdata(){
        Console.WriteLine("The name of the rectangle is:{0}",name);
        Console.WriteLine("The perimetrer of the ractangle is:{0}",width*2+height*2);
        Console.WriteLine("The area of the rectangle is:{0}",width*height);
        Console.WriteLine("The size of the diagonal is:{0}",Math.Sqrt((width*width)+(height*height)));
    }
}