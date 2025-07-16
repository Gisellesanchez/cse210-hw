using System;
using System.Diagnostics.Tracing;
using System.IO.Compression;


class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Circle myCircle2 = new Circle();
        myCircle2.SetRadius(20);
        Console.WriteLine($"{myCircle2.GetRadius()}");

        Console.WriteLine($"{myCircle.GetArea()}");
        Console.WriteLine($"{myCircle2.GetArea()}");

        Cylinder myCylinder = new Cylinder();
        myCylinder.SetHeight(10);
        myCylinder.SetCircle(myCircle);
        Console.WriteLine($"{myCylinder.GetVolume()}");
    }
}
 

 


class Circle
{
    private double _radius;

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("Error, radius must > 0");
            return;
        }
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
 


class Cylinder
{
    private Circle _circle;

    private double _height;

    public void SetCircle(Circle circle)
    {
        _circle = circle;
        SetHeight(10);
    }

    public void SetHeight(double height)
    {
        if(height < 0)
        {
            Console.WriteLine("Error, cannont set a negative value.");
            return;
        }
        _height = height;
    }

    public double GetVolume()
    {
        // double radius = _circle.GetRadius();
        return _circle.GetArea() * _height;
        // return Math.PI * radius * radius * _height;

    }
}
