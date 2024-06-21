using App_Console.Folder;

Console.WriteLine("****************************************");
Console.WriteLine("*             BAC A SABLE              *");
Console.WriteLine("****************************************");

Console.WriteLine("dP                 .8888b                   oo                   ");
Console.WriteLine("88                 88                                            ");
Console.WriteLine("88        .d8888b. 88aaa  .d8888b. dP    dP dP 88d888b. .d8888b. ");
Console.WriteLine("88        88'  `88 88     88'  `88 88    88 88 88'  `88 88ooood8 ");
Console.WriteLine("88        88.  .88 88     88.  .88 88.  .88 88 88    88 88.  ... ");
Console.WriteLine("88888888P `88888P8 dP     `88888P' `88888P' dP dP    dP `88888P' ");
Console.WriteLine();
Console.WriteLine("####    ####    ####    ####    ####    ####    ####    ####    #");
Console.WriteLine();
Console.WriteLine(" .d888888  dP dP            dP            dP");
Console.WriteLine("d8'    88  88 88            88            88");
Console.WriteLine("88aaaaa88a 88 88 .d8888b. d8888P .d8888b. 88d888b. dP    dP .d8888b.");
Console.WriteLine("88     88  88 88 88'  `88   88   88'  `88 88'  `88 88    88 Y8ooooo.");
Console.WriteLine("88     88  88 88 88.  .88   88   88.  .88 88.  .88 88.  .88       88");
Console.WriteLine("88     88  dP dP `88888P'   dP   `88888P' 88Y8888' `88888P' `88888P'");

Console.Write("Donne ton nom : ");
var askedName = Console.ReadLine();

var newPerson = new Person
{
    Firstname = askedName
};

Console.WriteLine($"Salut l'ami {newPerson.Firstname}");
Console.WriteLine();

// Lecture du dictionnary.txt pour écrire dans une nouvelle classe Mot
string filePath = "C:\\repos\\";
string fileName = "dictionary.txt";

var newListMot = new List<Mot>();

StreamReader streamReader = new StreamReader(Path.Combine(filePath, fileName));

// Lire la première ligne
var line = streamReader.ReadLine();

// Continuer à lire tant que line n'est pas null
while (line != null)
{
    // Ecrire une nouvelle classe Mot

    var newMot = new Mot();
    newMot.MotFr = line;
    newListMot.Add(newMot);

    // Lire la ligne suivante
    line = streamReader.ReadLine();
}

//Fermer le fichier dictionary.txt
streamReader.Close();

foreach (var mot in newListMot)
{
    Console.WriteLine($"Dans la liste de mots depuis fichier : {mot.MotFr}");
}


int nombreDeMotsEnChiffres = 666;

while (nombreDeMotsEnChiffres < 1 || nombreDeMotsEnChiffres > 10)
{
    Console.Write("Combien de mots veux-tu ajouter (1-10) ?  ");

    var nombreDeMots = Console.ReadLine();

    nombreDeMotsEnChiffres = int.Parse(nombreDeMots);
}

Console.WriteLine($"Tu as choisis d'ajouter {nombreDeMotsEnChiffres} mots.");

var listAddedWords = new List<Mot>();

for (var i = 0; i < nombreDeMotsEnChiffres; i++)
{
    Console.Write($"Ajoute le mot N° {i + 1} : ");

    // Demande le nouveau mot
    var newWord = Console.ReadLine();
    // Test s'il existe déjà
    bool wordExists = newListMot.Exists(m => m.MotFr == newWord);

    if (!wordExists)
    {
        // Ajouter le nouveau mot à la liste s'il n'existe pas
        listAddedWords.Add(new Mot { MotFr = newWord });
        Console.WriteLine($"Le mot '{newWord}' a été ajouté !!!");
    }
    else
    {
        Console.WriteLine($"Le mot '{newWord}' existe déjà !!!.");
    }
}

StreamWriter streamWriter = new StreamWriter(Path.Combine(filePath, fileName), true);

// Ecrire les nouveaux mots dans la console et dans le dictionary.txt
foreach (var mot in listAddedWords)
{
    Console.WriteLine($"La classe temp écrit : {mot.MotFr}");

    streamWriter.WriteLine(mot.MotFr);
}

streamWriter.Close();

// Lire le fichier dictionnary.txt
StreamReader inputFile = new StreamReader(Path.Combine(filePath, fileName));

// Lire la première ligne
line = inputFile.ReadLine();

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


// TODO
// One dictionary per user 
// Refactor the code
// Add the translation in english, in spanish
// Add question on words