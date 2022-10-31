using DiamondProblem.Devices;

namespace DiamondProblem
{
    class Program
    {
        static void Main(string[] Args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My Dissertation");
            c.Print("My Dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}