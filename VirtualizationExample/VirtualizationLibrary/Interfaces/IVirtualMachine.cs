namespace VirtualizationLibrary.Interfaces
{
    public interface IVirtualMachine : IVirtualizationObject
    {
        string Name { get; set; }

        IVirtualizationImage VirtualizationImage { get; set; }
    }
}
