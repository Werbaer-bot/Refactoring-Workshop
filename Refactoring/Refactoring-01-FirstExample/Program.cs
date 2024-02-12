using Newtonsoft.Json;
using Refactoring_01_FirstExample_Console;

string jsonInvoices = File.ReadAllText("invoices.json");
Invoices? invoices = JsonConvert.DeserializeObject<Invoices>(jsonInvoices);

string jsonPlays = File.ReadAllText("plays.json");
Plays? plays = JsonConvert.DeserializeObject<Plays>(jsonPlays);

var statement = Example.Statement(invoices.invoices[0], plays.plays);

Console.WriteLine(statement);