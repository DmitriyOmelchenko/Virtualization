using VirtualizationLibrary.Enums;

namespace VirtualizationLibrary.Interfaces
{
    public interface IVirtualizationObject
    {
        VirtualizationTypes Type { get; set; }

        bool Deleted { get; set; }
    }
}