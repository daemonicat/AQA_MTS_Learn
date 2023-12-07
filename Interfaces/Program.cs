// See https://aka.ms/new-console-template for more information

using Interfaces;
using Interfaces.BaseImpl;
using Interfaces.Example;
using Interfaces.ExplicitImpl;
using Interfaces.FinalExample;

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

// smartphone.DisplayInformation("Hello from smartphone!");
// tablet.DisplayInformation("Hello from tablet!");
//
// DisplayInformationOnDevice(smartphone, "Hello from smartphone!");
// DisplayInformationOnDevice(tablet, "Hello from tablet!");

static void DisplayInformationOnDevice(IDisplayable device, string information)
{
    device.DisplayInformation(information);
}

// tablet.DrawBorders();
// smartphone.DrawBorders();

Tablet1 tablet1 = new Tablet1();
tablet1.Charge();

IChargeable tablet21 = new Tablet1();
tablet21.Charge();

IDisplayable tablet22 = new Tablet1();
tablet22.DisplayInformation("MeowFrom22");

Tablet1 anotherTable1 = tablet1;
// Tablet1 anotherTable2 = tablet22;

if (tablet22 is Tablet1 anotherTable3) anotherTable3.DrawBorders();

// smartphone.DrawBorders();
((IDisplayable)smartphone).DrawBorders();
tablet.DrawBorders();
((IDisplayable)tablet).DrawBorders();

BaseAction baseAction = new BaseAction();
// baseAction.Move();
((IAction)baseAction).Move();
if (baseAction is IAction action) action.Move();
IAction baseAction2 = new BaseAction();
baseAction2.Move();

NewAction newAction = new NewAction();
((IAction) newAction).Move();
((IMovable) newAction).Move();

HeroAction heroAction = new HeroAction();
heroAction.Move();
((IAction) heroAction).Move();

// -======================== Реализация интерфейсов в базовых и производных классах ========================-
Tablet3 tablet3 = new Tablet3();
tablet3.DisplayInformation("Hello from tablet3!");

// -======================== Virtual
Tablet4 tablet41 = new Tablet4();
tablet41.DisplayInformation("Hello from tablet41!");

IDisplayable tablet42 = new Tablet4();
tablet42.DisplayInformation("Hello from tablet42!");

// -======================== New
Tablet5 tablet51 = new Tablet5();
tablet51.DisplayInformation("Hello from tablet51!");

IDisplayable tablet52 = new Tablet5();
tablet52.DisplayInformation("Hello from tablet52!");


// -======================== Задача ========================-
ApplicationTester applicationTester = new ApplicationTester();
applicationTester.AddTest(new IntegrationTest());
applicationTester.AddTest(new UnitTest());
applicationTester.AddTest(new UITest());

applicationTester.RunTests();