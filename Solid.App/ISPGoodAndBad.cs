public interface IWorker
{
    void Work();
}

public interface IEater
{
    void Eat();
}


public class Worker : IWorker
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Performing tasks...");
    }
}

public class Human : IWorker, IEater
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}
