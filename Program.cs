using cs_linq.DataSource;

// LINQ Language Integrated Query
Console.OutputEncoding = System.Text.Encoding.UTF8;

// where
#region where condizione
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var lowNums = numbers.Where(x => x < 5);
Logger.Titolo("Numeri < 5:");
Console.WriteLine(string.Join(",", lowNums));

#endregion

#region where condizione proprietà
var products = Products.ProductList;

var soldOutProducts = products.Where(x => x.UnitsInStock == 0);
Logger.Titolo("Prodotti esauriti:");
foreach (var p in soldOutProducts)
{
    Console.WriteLine(p);
}
#endregion

#region where condizione multipla
var prezzo = 50.00M;
var expensiveInStockProducts = products.Where(x => x.UnitPrice > prezzo && x.UnitsInStock > 0);

// oppure where concatenati
expensiveInStockProducts = products.Where(x => x.UnitsInStock > 0);
expensiveInStockProducts = expensiveInStockProducts.Where(x => x.UnitPrice > prezzo);
Logger.Titolo($"Prodotto in stock che costano più di {prezzo}");
foreach (var p in expensiveInStockProducts)
{
    Console.WriteLine(p);
}
#endregion

#region where in elenco
string[] digits = ["zero", "uno", "due", "tre", "quattro", "cinque", "sei", "sette", "otto", "nove"];
string[] numbersToFind = ["tre", "sei", "dodici"];

var numsFound = digits.Where(x => numbersToFind.Contains(x));
Logger.Titolo("Numeri da elenco:");
Console.WriteLine(string.Join(",", numsFound));
#endregion

// first, last, single (orDefault)
#region primo elemento
var product = expensiveInStockProducts.First();
#endregion

#region primo elemento match
string cominciaConS = digits.First(x => x.StartsWith("s"));
Logger.Titolo($"Prima stringa che comincia con s");
Console.WriteLine(cominciaConS);
#endregion

#region prima match o defaut
var product789 = products.FirstOrDefault(x => x.ProductID == 789);
Logger.Titolo("Prodotto con ID 789");
Console.WriteLine(product789?.ProductName);
#endregion

#region single
try
{
    // var prodotto = products.Single(x => x.UnitsInStock > 0);
    var prodotto = products.SingleOrDefault(x => x.ProductID == 1000);
    Logger.Titolo("Prodotto ID 1");
    Console.WriteLine(prodotto);
}
catch (System.Exception)
{
    Console.WriteLine("ERRORE");
}
#endregion

// all, any, contains
#region any matches
string[] words = ["uno", "due", "tre", "quattro"];
bool lm3 = words.Any(x => x.Length > 3);
Logger.Titolo("C'è almeno una parola con più di 3 lettere?");
Console.WriteLine(lm3);
#endregion

#region all matches
bool l3 = words.All(x => x.Length == 3);
Logger.Titolo("Tutte le parole sono lunghe 3");
Console.WriteLine(l3);
#endregion

#region contains
bool c2 = words.Contains("due");
Logger.Titolo("Contiene la parola 'due'?");
Console.WriteLine(c2);
#endregion
