// See https://aka.ms/new-console-template for more information

using App_Console.Folder;

Console.WriteLine("Hello, World!");
Console.WriteLine("My name is Lafouine !");
Console.WriteLine("Mine  is Philgood !");
Console.WriteLine("Welcome Everybody !");

Console.Write("Donne ton nom :");
var askedName = Console.ReadLine();

var bibi = new Class
{
    Name = askedName
};

Console.WriteLine($"Salut l'ami {bibi.Name}");
