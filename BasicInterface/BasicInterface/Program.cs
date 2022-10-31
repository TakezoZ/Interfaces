using BasicInterface.Entities;
using BasicInterface.Services;
using System.Globalization;

namespace BasicInterface
{
    class Program
    {
        static void Main(string[] Args)
        {

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:ss): ");
            DateTime pickUpDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:ss): ");
            DateTime returnDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(pickUpDate, returnDate, new Vehicle(carModel));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}