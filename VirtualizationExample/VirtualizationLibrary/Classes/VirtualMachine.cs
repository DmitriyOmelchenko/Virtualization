using VirtualizationLibrary.Enums;
using VirtualizationLibrary.Interfaces;

namespace VirtualizationLibrary.Classes
{
    public class VirtualMachine: IVirtualMachine
    {
        public string Name { get; set; }

        public IVirtualizationImage VirtualizationImage { get; set; }

        public VirtualizationTypes Type { get; set; }

        public bool Deleted { get; set; }

        public override string ToString()
        {
            return $"Virtual machine {Name} with Type {Type} with image {VirtualizationImage}";
        }
    }
}
