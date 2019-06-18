using System;
using VirtualizationLibrary.Enums;
using VirtualizationLibrary.Interfaces;

namespace VirtualizationLibrary.Classes
{
    public class OvhVirtualizationProvider: IVirtualizationProvider
    {
        public VirtualMachine CreateVirtualMachine(IVirtualizationImage image)
        {
            Console.WriteLine("Create vm by Ovh");

            return new VirtualMachine
            {
                Name = $"VM-{Guid.NewGuid()}",
                Type = VirtualizationTypes.Ovh,
                VirtualizationImage = image
            };
        }

        public bool DeleteVirtualMachine(IVirtualMachine virtualMachine)
        {
            virtualMachine.Deleted = true;

            Console.WriteLine($"Delete {virtualMachine} by Ovh provider");

            return true;
        }

        public bool ExecuteCommand(IVirtualMachine virtualMachine, string command)
        {
            Console.WriteLine($"Execute command {command} on {virtualMachine} by Ovh provider");

            return true;
        }
    }
}
