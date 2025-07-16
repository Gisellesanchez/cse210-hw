class Cylinder
{
    private Circle _circle;
    private double _height;

    private double _radius;

    public Cylinder()
    {
        _radius = 0;
    }
    public Cylinder(double radius, double height)
    {
        _circle = new Circle(radius);
        _height = height;
    }

    public void SetHeight(double height)
    {
        _height = height;
    }

    public void SetCircle(Circle circle)
    {
        _circle = circle;

    }
    
        
        }
}