using System;
using System.Collections.Generic;
using System.Text;
using VirtualizationLibrary.Enums;
using VirtualizationLibrary.Interfaces;

namespace VirtualizationLibrary.Classes
{
    public class VirtualizationContext: IVirtualizationProvider
    {
        private readonly AzureVirtualizationProvider _azureVirtualizationProvider;
        private readonly OvhVirtualizationProvider _ovhVirtualizationProvider;

        public VirtualizationContext(AzureVirtualizationProvider azureVirtualizationProvider,
            OvhVirtualizationProvider ovhVirtualizationProvider)
        {
            _azureVirtualizationProvider = azureVirtualizationProvider;
            _ovhVirtualizationProvider = ovhVirtualizationProvider;
        }

        public VirtualMachine CreateVirtualMachine(IVirtualizationImage image)
        {
            return GetProvider(image).CreateVirtualMachine(image);
        }

        public bool DeleteVirtualMachine(IVirtualMachine virtualMachine)
        {
            return GetProvider(virtualMachine).DeleteVirtualMachine(virtualMachine);
        }

        public bool ExecuteCommand(IVirtualMachine virtualMachine, string command)
        {
            return GetProvider(virtualMachine).ExecuteCommand(virtualMachine, command);
        }

        private IVirtualizationProvider GetProvider(IVirtualizationObject virtualizationObject)
        {
            switch (virtualizationObject.Type)
            {
                case VirtualizationTypes.Ovh:
                    return _ovhVirtualizationProvider;
                case VirtualizationTypes.Azure:
                    return _azureVirtualizationProvider;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
