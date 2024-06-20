using App_Console.Folder;

Console.WriteLine("****************************************");
Console.WriteLine("*                                      *");
Console.WriteLine("*             BAC A SABLE              *");
Console.WriteLine("*                                      *");
Console.WriteLine("*        lafouine & autobusman         *");
Console.WriteLine("*                                      *");
Console.WriteLine("****************************************");

Console.Write("Donne ton nom : ");
var askedName = Console.ReadLine();

var newPerson = new Person
{
    Firstname = askedName
};

Console.WriteLine($"Salut l'ami {newPerson.Firstname}");
