namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gaming Computer
            Computer gamingPC = new ComputerBuilder()
                .SetProcessor("Intel i9")
                .SetRAM(32)
                .SetStorage(1000)
                .SetGraphicsCard(true)
                .SetOperatingSystem("Windows 11")
                .Build();

            Console.WriteLine("--- Gaming Computer ---");
            gamingPC.PrintSpecs();

            Console.WriteLine();

            // Office Computer
            Computer officePC = new ComputerBuilder()
                .SetProcessor("Intel i5")
                .SetRAM(8)
                .SetStorage(256)
                .SetGraphicsCard(false)
                .SetOperatingSystem("Windows 10")
                .Build();

            Console.WriteLine("--- Office Computer ---");
            officePC.PrintSpecs();
        }
    }
}
