// See https://aka.ms/new-console-template for more information

using Generics;

var simplePerson = new SimplePerson(546, "Tom");
var objectPerson = new ObjectPerson("abc123", "Bob");

var tomId = simplePerson.Id;
var bobId = (string)objectPerson.Id;

Console.WriteLine($"Tom ID: {tomId}");
Console.WriteLine($"Bob ID: {bobId}");


var objectPerson1 = new ObjectPerson(123, "Bob"); // упаковка в значения int в тип Object
var intBobId = (int)objectPerson1.Id; // Распаковка в тип int
// string strBobId = (string)objectPerson1.Id;                  // Ошибка при выполнении

// -=================== Generics ===================- 
var intPerson = new GenericPerson<int>(123, "Alex");
intPerson.Print();

var strPerson = new GenericPerson<string>("- 123 -", "Alex");
var uniquePerson = new GenericPerson<Guid>(Guid.NewGuid(), "Alex");
uniquePerson.Print();

var intAlexId = intPerson.Id;
var strAlexId = strPerson.Id;

var mtCompany = new Company<GenericPerson<Guid>>(uniquePerson);

// -=================== Static
// StaticPerson.code = 123; // Ошибка - отсутствует типизация
StaticPerson<int>.Code = 123;
StaticPerson<string>.Code = "- 123 -";

Console.WriteLine(StaticPerson<int>.Code);
Console.WriteLine(StaticPerson<string>.Code);

var alex = new Person<Guid, string>(Guid.NewGuid(), "wp", "Alex");
var olga = new Person<Guid, int>(Guid.NewGuid(), 1, "Olga");

var x = 10;
var y = 15;
Helper.Swap(ref x, ref y);

var x1 = "10";
var y1 = "15";
Helper.Swap<string>(ref x1, ref y1);

// -=================== Ограничения Generics ===================-
Helper.SendMessage(new EmailMessage("Bye World"));
Helper.SendMessage(new EmailMessage("Bye World"));

var telegram = new Messenger<Message>();
telegram.SendMessage(new Message("Hello World"));

var outlook = new Messenger<EmailMessage>();
outlook.SendMessage(new EmailMessage("Bye World"));

var messengerStruct = new MessengerStruct<MessageStruct>();
// MessengerStruct<int> // Ошибка - int не struct
// MessengerStruct<Message> // Ошибка - class не struct
messengerStruct.SendMessage(new MessageStruct("Struct is cool for small objects..."));

var smsMessengerClass = new MessengerClass<SmsMessage>();
// MessengerClass<int> // Ошибка
// MessengerClass<string> // string = class  
smsMessengerClass.SendMessage(new SmsMessage("SMS is not actual anymore..."));

// MessengerNew<SmsMessage> nMessengerNew = new MessengerNew<SmsMessage>(); // Ошибка потому что у SmsMessage нет конструктора без параметров 
var nMessengerNew = new MessengerNew<EmailMessage>(); // Все ок

var sender = new SimplePerson(1, "Ted");
var receiver = new SimplePerson(3, "Fred");
var messengerService = new MessengerService<EmailMessage, SimplePerson>();
messengerService.SendMessage(sender, receiver, new EmailMessage("Email..."));

var childGenericPerson = new ChildGenericPerson<Guid>(Guid.NewGuid(), "Toma");
var intGenericPerson = new IntGenericPerson(1, "Vera");
var varyGenericPerson = new VaryGenericPerson<string>(2, "Gena", "12222");
var childWherePerson = new ChildWherePerson<string>("1/2", "Dolly");
var childWherePerson1 =
    new ChildWherePerson<SimplePerson>(new SimplePerson(3, "Sam"), "Dolly");