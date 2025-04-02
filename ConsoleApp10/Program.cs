


using ConsoleApp10.Models;
Hotel hotel = new Hotel("Iron");
while (true)
{
    Console.WriteLine(@"1. Create a room - otaq yaratmaq
2. Add room - otaq əlavə etmək
3. Make reserve - rezerv etmək
0. Exit - Çıxış");

   

    Console.WriteLine("Secim");

    int choise;
    bool ischeck = int.TryParse(Console.ReadLine(), out choise);
    bool check = false;
    if (ischeck)
    {
        switch (choise)
        {
            case 1:
                
                while(!check)
                {
                    Console.Write("Name: ");
                    string Name = (Console.ReadLine());

                    Console.Write("Price: ");
                    check = int.TryParse(Console.ReadLine(),out int price);
                    Console.Write("P capacity: ");
                    check = int.TryParse(Console.ReadLine(),out int pcapas);
                    if(!check)
                    {
                        Console.WriteLine("Sehv daxil etdiniz");
                    }
                    if (check)
                    {
                        Room room = new Room(Name, price, pcapas);
                    }
                }
          
                Console.WriteLine("Room yaradildi");
                check=false;
                break;
            case 2:
                while (!check)
                {
                    Console.Write("Name: ");
                    string Name = (Console.ReadLine());

                    Console.Write("Price: ");
                    check = int.TryParse(Console.ReadLine(), out int price);
                    Console.Write("P capacity: ");
                    check = int.TryParse(Console.ReadLine(), out int pcapas);
                    if (!check)
                    {
                        Console.WriteLine("Sehv daxil etdiniz");
                    }
                    if (check)
                    {
                        Room room = new Room(Name, price, pcapas);
                        hotel.AddRoom(room);
                       
                    }
                }

                
                Console.WriteLine("Room elave edildi");
                check=false;
                break;
            case 3:
                while (!check)
                {
                    Console.Write("Id: ");
                    check = int.TryParse(Console.ReadLine(), out int id);
                    if (!check)
                    {
                        Console.WriteLine("Sehv daxil etdiniz");
                    }
                    if (check)
                    {

                        hotel.MakeReservation(id);
                    }
                }
                break;
            case 0:
                Console.WriteLine("Exit");
                break;
            default:
                break;
        }
        
    }
    else
    {
        Console.WriteLine("sehv secim");
    }
}