abstract class Worker
{
    private string _name;
    private string _position;
    private List<string> _workDay = new List<string>();
    public Worker(string name)
    {
        this._name = name;
        _position = "";
        _workDay = new List<string>();
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Position
    {
        get { return _position; }
        set { _position = value; }
    }

    public List<string> WorkDay
    {
        get { return _workDay; }
        set { _workDay = value; }
    }

    public string GetAllWorkDays()
    {
        string days = "";
        foreach(string day in _workDay)
        {
            days += day + " ";
        }

        return days;
    }

    public virtual void Call()
    {
        Console.WriteLine("A call was made.");
    }

    public virtual void WriteCode()
    {
        Console.WriteLine("A code was written.");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Relax Time");
    }

    public abstract void FillWorkDay();
}

class Developer: Worker
{
    public Developer(string name): base(name)
    {
        this.Position = "Developer";
        WorkDay = new List<string>();
    }

    public override void FillWorkDay()
    {
        Call();
        WriteCode();
        Relax();
    }
}

class Manager: Worker
{
    private Random _random = new Random();
    public Manager(string name) : base(name)
    {
        this.Position = "Manager";
        WorkDay = new List<string>();
    }

    public override void FillWorkDay()
    {
        Console.WriteLine("-----WORKDAY-----");
        for(int i = 0; i < _random.Next(1, 10); i++)
        {
            Call();
        }
        Console.WriteLine(" ");
        Relax();
        Console.WriteLine(" ");
        for (int i = 0; i < _random.Next(1, 5); i++)
        {
            Call();
        }
        Console.WriteLine("-----------------");
    }
}

class Team
{
    private string _teamName;
    private List<Worker> _workersList = new List<Worker>();
    public Team(string name)
    {
        this._teamName = name;
    }

    public void AddWorker(Worker newWorker)
    {
        _workersList.Add(newWorker);
    }

    public void GetInfo()
    {
        Console.WriteLine("Team name: " + _teamName);
        Console.WriteLine("Workers' names: ");
        foreach(Worker w in _workersList)
        {
            Console.WriteLine(w.Name);
        }
    }

    public void GetDetailedInfo()
    {
        Console.WriteLine("Team name: " + _teamName);
        Console.WriteLine("Information about workers: ");
        foreach (Worker w in _workersList)
        {
            Console.WriteLine("<" + w.Name + "> - <" + w.Position + "> - <" + w.GetAllWorkDays() + ">");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Developer firstDeveloper = new Developer("Anya");
        Developer secondDeveloper = new Developer("Ilona");

        Manager firstManager = new Manager("Mariia");
        Manager secondManager = new Manager("Alina");

        firstDeveloper.WorkDay = new List<string>() { "Monday", "Wednesday", "Friday" };
        secondDeveloper.WorkDay = new List<string>() { "Tuesday", "Thursday", "Saturday" };
        firstManager.WorkDay = new List<string>() { "Monday", "Wednesday", "Friday" };
        secondManager.WorkDay = new List<string>() { "Tuesday", "Thursday", "Saturday" };

        Console.WriteLine("---------------------");

        Team Team1 = new Team("First Team");
        Team1.AddWorker(firstDeveloper);
        Team1.AddWorker(firstManager);

        Team1.GetInfo();

        Console.WriteLine("* * *");

        Team1.GetDetailedInfo();

        Console.WriteLine("---------------------");

        Team Team2 = new Team("Second Team");
        Team2.AddWorker(secondDeveloper);
        Team2.AddWorker(secondManager);

        Team2.GetInfo();

        Console.WriteLine("* * *");

        Team2.GetDetailedInfo();

        Console.WriteLine("---------------------");

        firstManager.FillWorkDay();

        Console.ReadKey(); 
    }
}


