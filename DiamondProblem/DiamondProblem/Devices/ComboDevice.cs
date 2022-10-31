using System.Reflection.Metadata;

namespace DiamondProblem.Devices
{
    internal class ComboDevice : Device, IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine($"ComboDevice print {document}");
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"ComboDevice processing {document}");
        }

        public string Scan()
        {
            return "ComboDevice Scan result";
        }
    }
}
