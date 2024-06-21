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

string filePath = "C:\\repos\\";
string fileName = "dictionary.txt";

StreamWriter streamWriter = new StreamWriter(Path.Combine(filePath, fileName), true);

// Ecrire les nouveaux mots dans la console et dans le dictionary.txt
foreach (var mot in listeMots)
{
    Console.WriteLine($"La classe écrit : {mot.MotFr}");

    streamWriter.WriteLine(mot.MotFr);
    //using (StreamWriter outputFile = new StreamWriter(Path.Combine(filePath, fileName), true))
    //{
    //    outputFile.WriteLine(mot.MotFr);
    //}
}

streamWriter.Close();

// Lire le fichier dictionnary.txt
StreamReader inputFile = new StreamReader(Path.Combine(filePath, fileName));

// Lire la première ligne
var line = inputFile.ReadLine();

// Continuer à lire tant que line n'est pas null
while (line != null)
{
    // Ecrire la ligne dans la console
    Console.WriteLine($"Le fichier écrit : {line}");

    // Lire la ligne suivante
    line = inputFile.ReadLine();
}

//Fermer le fichier dictionary.txt
inputFile.Close();



Console.WriteLine();

// TODO
// Check if the word already exists
// Add the translation in english, in spanish
// Refactor the code