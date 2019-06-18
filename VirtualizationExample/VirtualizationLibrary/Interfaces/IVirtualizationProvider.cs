using VirtualizationLibrary.Classes;

namespace VirtualizationLibrary.Interfaces
{
    public interface IVirtualizationProvider
    {
        VirtualMachine CreateVirtualMachine(IVirtualizationImage image);

        bool DeleteVirtualMachine(IVirtualMachine virtualMachine);

        bool ExecuteCommand(IVirtualMachine virtualMachine, string command);
    }
}