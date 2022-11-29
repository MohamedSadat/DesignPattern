// See https://aka.ms/new-console-template for more information
using projIterator;

Console.WriteLine("Iterator pattern!");
var h = new BrowserHistory();
h.Push("main");
h.Push("sales");
h.Push("orders");
h.Push("order 123");


var i = h.CreateIterator();
while (i.HasNext())
{
    var url = i.Current();
    Console.WriteLine(url);
    i.Next();
    
}
Console.ReadLine();
