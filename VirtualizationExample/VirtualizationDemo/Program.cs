using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.Extensions.DependencyInjection;
using VirtualizationLibrary.Classes;
using VirtualizationLibrary.Enums;
using VirtualizationLibrary.Interfaces;

namespace VirtualizationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();

            var virtualizationContext = serviceProvider.GetService<IVirtualizationProvider>();

            var images = new VirtualizationImage[]
            {
                new VirtualizationImage{Name = "True Windows 10", Type = VirtualizationTypes.Azure},
                new VirtualizationImage{Name = "Server Windows 2016", Type = VirtualizationTypes.Ovh}
            };

            foreach (var virtualizationImage in images)
            {
                var vm = virtualizationContext.CreateVirtualMachine(virtualizationImage);

                virtualizationContext.ExecuteCommand(vm, "Hello, World!");

                virtualizationContext.DeleteVirtualMachine(vm);
            }

            Console.WriteLine("That's all folks");
            Console.ReadKey();
        }

        private static ServiceProvider ConfigureServices()
        {
            var collection = new ServiceCollection();

            collection.AddTransient<AzureVirtualizationProvider>();
            collection.AddTransient<OvhVirtualizationProvider>();
            collection.AddTransient<IVirtualizationProvider, VirtualizationContext>();

            return collection.BuildServiceProvider();
        }
    }
}
