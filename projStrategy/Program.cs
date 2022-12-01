// See https://aka.ms/new-console-template for more information
using projStrategy;

Console.WriteLine("Hello, World!");

var i = new ImageStorage(new JPegCompressor(), new BAWFilter());
i.Store("");
Console.ReadLine();
