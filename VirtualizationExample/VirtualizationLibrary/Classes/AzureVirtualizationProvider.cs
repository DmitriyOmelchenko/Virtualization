using System;
using VirtualizationLibrary.Enums;
using VirtualizationLibrary.Interfaces;

namespace VirtualizationLibrary.Classes
{
    public class AzureVirtualizationProvider: IVirtualizationProvider
    {
        public VirtualMachine CreateVirtualMachine(IVirtualizationImage image)
        {
            Console.WriteLine("Create vm by Azure");

            return new VirtualMachine
            {
                Name = $"VM-{Guid.NewGuid()}",
                Type = VirtualizationTypes.Azure,
                VirtualizationImage = image
            };
        }

        public bool DeleteVirtualMachine(IVirtualMachine virtualMachine)
        {
            Console.WriteLine($"Delete vm {virtualMachine}");

            virtualMachine.Deleted = true;

            return true;
        }

        public bool ExecuteCommand(IVirtualMachine virtualMachine, string command)
        {
            Console.WriteLine($"Execute command {command} on {virtualMachine} by Azure provider");

            return true;
        }
    }
}