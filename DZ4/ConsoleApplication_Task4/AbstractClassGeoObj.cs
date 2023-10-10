using System;
abstract class GeographicalObject
{
    protected double _coordinateX;
    protected double _coordinateY;
    protected string _name = "";
    protected string _description = "";

    public GeographicalObject(string name)
    {
        this._name = name;
        this._coordinateX = 0;
        this._coordinateY = 0;
        this._description = "";
    }

    public abstract double CoordinateX
    {
        get; set;
    }

    public abstract double CoordinateY
    {
        get; set;
    }

    public abstract string Name
    {
        get; set;
    }

    public abstract string Description
    {
        get; set;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine("Information about a geographical object.");
        Console.WriteLine("Name of geographical object: " + _name);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Coordinate X: " + _coordinateX);
        Console.WriteLine("Coordinate Y: " + Convert.ToString(_coordinateY));
    }
}

class River: GeographicalObject
{
    private double _flowRate;
    private double _length;

    public River(string name) : base(name)
    {
        this._flowRate = 0;
        this._length = 0;
    }

    public override double CoordinateX
    {
        get { return _coordinateX; }
        set { _coordinateX = value; }
    }

    public override double CoordinateY
    {
        get { return _coordinateY; }
        set { _coordinateY = value; }
    }

    public override string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public override string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public double FlowRate
    {
        get { return _flowRate; }
        set { _flowRate = value; }
    }

    public double Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public override void GetInfo()
    {
        Console.WriteLine("Information about a river.");
        Console.WriteLine("Name of river: " + _name);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Coordinate X: " + Convert.ToString(_coordinateX));
        Console.WriteLine("Coordinate Y: " + Convert.ToString(_coordinateY));
        Console.WriteLine("Flow rate: " + Convert.ToString(_flowRate));
        Console.WriteLine("Length: " + Convert.ToString(_length));
    }
}

class Mountain: GeographicalObject
{
    private double _highestPoint;

    public Mountain(string name): base(name)
    {
        this._highestPoint = 0;
    }

    public override double CoordinateX
    {
        get { return _coordinateX; }
        set { _coordinateX = value; }
    }

    public override double CoordinateY
    {
        get { return _coordinateY; }
        set { _coordinateY = value; }
    }

    public override string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public override string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public double HighestPoint
    {
        get { return _highestPoint; }
        set { _highestPoint = value; }
    }

    public override void GetInfo()
    {
        Console.WriteLine("Information about a mountain.");
        Console.WriteLine("Name of mountain: " + _name);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Coordinate X: " + Convert.ToString(_coordinateX));
        Console.WriteLine("Coordinate Y: " + Convert.ToString(_coordinateY));
        Console.WriteLine("Highest point: " + Convert.ToString(_highestPoint));
    }
}

class Program
{
    static void Main(string[] args)
    {
        River Dnipro = new River("Dnipro");
        Dnipro.Description = "Dnipro is the fourth-longest river in Europe and the third-largest in terms " +
            "of basin area, and the river with the longest course in Ukraine.";
        Dnipro.CoordinateX = 55;
        Dnipro.CoordinateY = 33;
        Dnipro.FlowRate = 60;
        Dnipro.Length = 2201;

        Dnipro.GetInfo();

        Console.ReadKey();
    }
}
