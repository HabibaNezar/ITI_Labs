using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class ComputerBuilder
    {
        private Computer computer = new Computer();
		public ComputerBuilder SetProcessor(string processorName)
        {
            computer.Processor = processorName;
            return this;
        }

        public ComputerBuilder SetRAM(int ram)
        {
            computer.RAM = ram;
            return this;
        }
        public ComputerBuilder SetStorage(int storage)
        {
            computer.Storage = storage;
            return this;
        }
        public ComputerBuilder SetGraphicsCard(bool graphicCard)
        {
            computer.HasGraphicsCard = graphicCard;
            return this;
        }
        public ComputerBuilder SetOperatingSystem(string os)
        {
            computer.OperatingSystem = os;
            return this;
        }
        public Computer Build()
        {
            return computer;
        }





    }
}
