namespace ConsoleApp10.Models;

class Room
{

    static int _id = 1;

    public int Id { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }

    public int PersonCapacity { get; set; }

    public bool IsAvailable { get; set; } = true;


    public Room(string name, double price, int personCapacity)
    {
        Id = _id++;
        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
    }


    public void showInfo()
    {

        Console.WriteLine($"{Id}{Name}{PersonCapacity}{Price}");
    }
}
