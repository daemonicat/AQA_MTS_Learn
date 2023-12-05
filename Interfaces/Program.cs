// See https://aka.ms/new-console-template for more information

using Interfaces;
using Interfaces.Example;

Console.WriteLine("Hello, World!");

// ===================================== Static =====================================
/*StaticExample staticExample1 = new StaticExample();
Console.WriteLine($"staticExample1: staticVar1 = {StaticExample.StaticVar}; instanceVar1 = {staticExample1.InstanceVar}");
StaticExample staticExample2 = new StaticExample();
Console.WriteLine($"staticExample2: staticVar2 = {StaticExample.StaticVar}; instanceVar2 = {staticExample2.InstanceVar}");
StaticExample staticExample3 = new StaticExample();
Console.WriteLine($"staticExample3: staticVar3 = {StaticExample.StaticVar}; instanceVar3 = {staticExample3.InstanceVar}");*/

// ===================================== Interfaces =====================================
// IDisplayable displayable = new IDisplayable();

Smartphone smartphone = new Smartphone();
Tablet tablet = new Tablet();

smartphone.DisplayInformation("Hello from smartphone!");
tablet.DisplayInformation("Hello from tablet!");

DisplayInformationOnDevice(smartphone, "Hello from smartphone!");
DisplayInformationOnDevice(tablet, "Hello from tablet!");

static void DisplayInformationOnDevice(IDisplayable device, string information)
{
    device.DisplayInformation(information);
}

tablet.DrawBorders();
// smartphone.DrawBorders();

Tablet1 tablet1 = new Tablet1();
tablet1.Charge();