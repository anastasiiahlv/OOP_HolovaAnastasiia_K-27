using System.Xml.Linq;

interface IGeographicalObject
{
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

    public void GetInfo();
}

public class River : IGeographicalObject
{
    protected double _coordinateX;
    protected double _coordinateY;
    protected string _name = "";
    protected string _description = "";
    protected double _flowRate;
    protected double _length;
    
    public River(string name)
    {
        this._name = name;
        this._coordinateX = 0;
        this._coordinateY = 0;
        this._description = "";
        this._flowRate = 0;
        this._length = 0;
    }

    public double CoordinateX
    {
        get { return _coordinateX; }
        set { _coordinateX = value; }
    }

    public double CoordinateY
    {
        get { return _coordinateY; }
        set { _coordinateY = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
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
    public void GetInfo()
    {
        Console.WriteLine("Information about a river.");
        Console.WriteLine("Name of river: " + _name);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Coordinate X: " + Convert.ToString(_coordinateX));
        Console.WriteLine("Coordinate Y: " + Convert.ToString(_coordinateY));
        Console.WriteLine("Length: " + Convert.ToString(_length));
    }
}

public class Mountain : IGeographicalObject
{
    protected double _highestPoint;
    protected double _coordinateX;
    protected double _coordinateY;
    protected string _name = "";
    protected string _description = "";

    public Mountain(string name)
    {
        this._name = name;
        this._coordinateX = 0;
        this._coordinateY = 0;
        this._description = "";
        this._highestPoint = 0;
    }

    public double CoordinateX
    {
        get { return _coordinateX; }
        set { _coordinateX = value; }
    }

    public double CoordinateY
    {
        get { return _coordinateY; }
        set { _coordinateY = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public double HighestPoint
    {
        get { return _highestPoint; }
        set { _highestPoint = value; }
    }

    public void GetInfo()
    {
        Console.WriteLine("Information about a mountain.");
        Console.WriteLine("Name of mountain: " + _name);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Coordinate X: " + Convert.ToString(_coordinateX));
        Console.WriteLine("Coordinate Y: " + Convert.ToString(_coordinateY));
        Console.WriteLine("Highest point: " + Convert.ToString(_highestPoint));
    }
}