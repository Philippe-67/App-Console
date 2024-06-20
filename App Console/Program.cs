using App_Console.Folder;

Console.WriteLine("****************************************");
Console.WriteLine("*                                      *");
Console.WriteLine("*             BAC A SABLE              *");
Console.WriteLine("*                                      *");
Console.WriteLine("*        lafouine & allotobus          *");
Console.WriteLine("*                                      *");
Console.WriteLine("****************************************");

Console.Write("Donne ton nom : ");
var askedName = Console.ReadLine();

var newPerson = new Person
{
    Firstname = askedName
};

Console.WriteLine($"Salut l'ami {newPerson.Firstname}");
Console.WriteLine();

int nombreDeMotsEnChiffres = 666;

while (nombreDeMotsEnChiffres < 1 || nombreDeMotsEnChiffres > 10)
{
    Console.Write("Combien de mots veux-tu ajouter (1-10) ?  ");

    var nombreDeMots = Console.ReadLine();

    nombreDeMotsEnChiffres = int.Parse(nombreDeMots);
}

Console.WriteLine($"Tu as choisis d'ajouter {nombreDeMotsEnChiffres} mots.");

var listeMots = new List<Mot>();

for (var i = 0; i < nombreDeMotsEnChiffres; i++)
{
    Console.Write($"Ajoute le mot N° {i + 1} : ");

    var motEnPlus = Console.ReadLine();

    var nouveauMot = new Mot()
    {
        MotFr = motEnPlus
    };

    listeMots.Add(nouveauMot);
}

foreach (var mot in listeMots)
{
    Console.WriteLine(mot.MotFr);
}
