// See https://aka.ms/new-console-template for more information
using ChainOfResp;

Console.WriteLine("Hello, World!");
var c = new Post(null);
var logger = new PeriodValidator(c);
var auth = new PermissionValidator(logger);

var server = new Ledger(auth);
server.Handle(new Journal {Amount=300 });
Console.ReadLine();
