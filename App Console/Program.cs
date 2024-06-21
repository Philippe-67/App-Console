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

// déclartion des variables composant le chemin et le nom du fichier user.firstnamedictionnary.txt 
string filePath = "C:\\repos\\";
string fileName = ($"{newPerson.Firstname}dictionary.txt");

//instansiation d'une liste de mots 
var newListMot = new List<Mot>();
var line = "";


if (File.Exists(Path.Combine(filePath, fileName)))
{
    ///Ouverture en mode lecture du fichier
    using (StreamReader streamReader = new StreamReader(Path.Combine(filePath, fileName)))
    {
        // Lire la première ligne
        line = streamReader.ReadLine();

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



        foreach (var mot in newListMot)
        {
            Console.WriteLine($"Dans classe depuis fichier : {mot.MotFr}");
        }
    } }


else
{ Console.WriteLine("nous allons creer un dictionnaire à ton nom"); }
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

    
        ///ouverture en mode écriture du fichier userfirstnamedictionnary 
        StreamWriter streamWriter = new StreamWriter(Path.Combine(filePath, fileName), true);

        // affichage des nouveaux mots dans la console et consignation dans  le dictionnary.txt
        foreach (var mot in listeMots)
        {
            Console.WriteLine($"La classe écrit : {mot.MotFr}");
            streamWriter.WriteLine(mot.MotFr);
        }
        ///fermeture de userfirstnamedictionnary
        streamWriter.Close();

        // Lire le fichier dictionnary.txt
        StreamReader inputFile = new StreamReader(Path.Combine(filePath, fileName));

        // Lire la première ligne
        var line2 = inputFile.ReadLine();

        // Continuer à lire tant que line n'est pas null
        while (line2 != null)
        {
            // Ecrire la ligne dans la console
            Console.WriteLine($"Le fichier écrit : {line2}");

            // Lire la ligne suivante
            line2 = inputFile.ReadLine();
        }

        //Fermer le fichier dictionary.txt
        inputFile.Close();



        Console.WriteLine();
   


// TODO
// Check if the word already exists
// Add the translation in english, in spanish
// Refactor the code