
namespace ClassBasics
{
     class App
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("This is the first dot net program");
            PassengerManagement.Features.Passenger obj = new PassengerManagement.Features.Passenger();
            obj.AddPassenger();
        }
    }  
}

namespace PassengerManagement
{
    namespace Features 
    { 
        class Passenger
        {
             protected internal void AddPassenger()
            {
                System.Console.WriteLine("Passenger Added");
            }
        }
    }
}