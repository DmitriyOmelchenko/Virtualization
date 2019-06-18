using VirtualizationLibrary.Enums;
using VirtualizationLibrary.Interfaces;

namespace VirtualizationLibrary.Classes
{
    public class VirtualizationImage: IVirtualizationImage
    {
        public string Name { get; set; }

        public VirtualizationTypes Type { get; set; }

        public bool Deleted { get; set; }

        public override string ToString()
        {
            return $"Image {Name} of type - {Type}";
        }
    }
}
