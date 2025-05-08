using System;


class Circle
{
    private double _radius;


    public void SetRadius(double radius)
    {
        
        if (radius < 0 )

        {
            Console.WriteLine("Error");
            return; 
        }
       _radius = radius;
    }

   public  double GetRadius()
    {
        return _radius;
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World]!");

        Circle myCircle = new Circle();
        //Circle myCircle2 = new Circle();
        myCircle.SetRadius(10);
       // myCircle._radius = 20;
        Console.WriteLine($"{myCircle.GetRadius()}");

         myCircle2.SetRadius(20);
          Console.WriteLine($"{myCircle2.GetRadius()}");

          Console.WriteLine($"The area of the circle is: {myCircle.GetArea()}");
            Console.WriteLine($"The area of the circle is: {myCircle2.GetArea()}");


      Cylinder myCylinder = new Cylinder();
        myCylinder.SetCircle(myCircle);
        myCylinder.SetHeight(10);
        Console.WriteLine($"The volume of the cylinder is: {myCylinder.GetVolume()}");

        //List<int> myNumbers = new List<int>();
        Console.WriteLine($"The volume of the cylinder is: {myCylinder.GetVolume()}");

        //List<int> myNumbers = new List<int>();


//List<int> myNumbers + new List<int>();
  //  myNumbers.Add(10);
    //myNumbers.Add(99);
    //myNumbers.Add(-123)


//foreach (int i in myNumbers);
{
    //Console.WriteLine(i);
}
        //This is a fun comment 

        //second comment
    //third comment 
    }
}