// See https://aka.ms/new-console-template for more information
using projObserver;

Console.WriteLine("Hello, World!");
var ds = new DataSource();
var sheet1 = new SpreedSheet(ds);
var sheet2 = new SpreedSheet(ds);
var chart=new Chart(ds);
ds.AddObserver(sheet1);
ds.AddObserver(sheet2);
ds.AddObserver(chart);
ds.Value = 55;
Console.ReadLine();


