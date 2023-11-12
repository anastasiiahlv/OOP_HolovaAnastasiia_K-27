using System;
using System.ComponentModel;

class Task4_Program
{
    static void Main()
    {
        ConcreteChristmasTree christmasTree = new ConcreteChristmasTree();
        OrnamentsDecorator ornamentsDecorator = new OrnamentsDecorator();
        GarlandDecorator garlandDecorator = new GarlandDecorator();

        ornamentsDecorator.SetChristmasTree(christmasTree);
        garlandDecorator.SetChristmasTree(ornamentsDecorator);

        garlandDecorator.Display();

        Console.ReadKey();
    }
}

// Component
abstract class ChristmasTree
{
    public abstract void Display();
}

// Concrete Component
class ConcreteChristmasTree : ChristmasTree
{
    public override void Display()
    {
        Console.WriteLine("Christmas tree");
    }
}

// Decorator 
abstract class Decorator : ChristmasTree
{
    #nullable disable
    protected ChristmasTree christmasTree;
    #nullable enable

    public void SetChristmasTree(ChristmasTree christmasTree) { this.christmasTree = christmasTree; }

    public override void Display()
    {
        if (christmasTree != null)
        {
            christmasTree.Display();
        }
    }
}

// Concrete Decorator A
class OrnamentsDecorator : Decorator
{
    private string? addedOrnament;

    public override void Display()
    {
        base.Display();
        addedOrnament = "Christmas tree decorated with Christmas ornaments";
        Console.WriteLine(addedOrnament);
    }
}

// Concrete Decorator B
class GarlandDecorator : Decorator
{
    public void GarlandIsOn()
    {
        Console.WriteLine("A glowing garland on the Christmas tree ");
    }

    public override void Display()
    {
        base.Display();
        GarlandIsOn();
    }
}

