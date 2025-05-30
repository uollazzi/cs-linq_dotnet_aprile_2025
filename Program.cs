using cs_linq.DataSource;
using cs_linq.Models;

// LINQ Language Integrated Query
Console.OutputEncoding = System.Text.Encoding.UTF8;

// select
#region select syntax
int[] numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];

var numsPlusOne = numbers.Select(x => x + 1);
Logger.Titolo("Numeri + 1");
Console.WriteLine(string.Join(",", numsPlusOne));
#endregion

#region select property
var productsNames = Products.ProductList.Select(x => x.ProductName);
Logger.Titolo("Solo nomi");

foreach (var name in productsNames)
{
    Console.WriteLine(name);
}
#endregion

#region select transform
string[] strings = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];

var textNums = numbers.Select(n => strings[n]);

Logger.Titolo("Numeri in stringa");
Console.WriteLine(string.Join(" ", textNums));

#endregion

#region select anonymous type
var gigi = new { Nome = "Gigi", Cognome = "Verdi" }; // tipo anonimo
Console.WriteLine(gigi.Cognome);

string[] words = ["aPPLE", "BlUeBeRrY", "cHeRry"];

var transformedWords = words.Select(x => new
{
    Upper = x.ToUpper(),
    Lower = x.ToLower()
});
Logger.Titolo("Upper/Lower");
foreach (var ul in transformedWords)
{
    Console.WriteLine($"Upper: {ul.Upper}, Lower: {ul.Lower}");
}
#endregion

#region select new type
var digitOddEvens = numbers.Select(x => new Dummy(strings[x], x % 2 == 0));
Logger.Titolo("Cifra/Pari/Dispari");
foreach (var d in digitOddEvens)
{
    Console.WriteLine($"La cifra {d.Digit} è {(d.Even ? "pari" : "dispari")}.");
}
#endregion

#region select subset properties
var productInfos = Products.ProductList.Where(x => x.UnitsInStock > 0).Select(x => new { x.ProductName, x.Category, Price = x.UnitPrice });
Logger.Titolo("Prodotti");
foreach (var productInfo in productInfos)
{
    Console.WriteLine($"{productInfo.ProductName} è nella categoria {productInfo.Category} e costa {productInfo.Price:C} per unità.");
}
#endregion