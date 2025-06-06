using cs_linq;
using cs_linq.DataSource;
using cs_linq.Models;

// LINQ Language Integrated Query
Console.OutputEncoding = System.Text.Encoding.UTF8;

#region orderby syntax
string[] words = ["cherry", "apple", "blueberry"];

var sortedWords = words.OrderBy(o => o);

Logger.Titolo("Parole ordinate");
Console.WriteLine(string.Join(" ", sortedWords));
#endregion

#region orderby-property
var sortedProducts = Products.ProductList.OrderByDescending(o => o.ProductName);

Logger.Titolo("Prodotti ordinati per nome");
foreach (var p in sortedProducts)
{
    Console.WriteLine(p);
}
#endregion

#region thenby
var sortedProductsByCategoryAndPrice =
    Products.ProductList.OrderBy(o => o.Category)
                        .ThenByDescending(o => o.UnitPrice);

Logger.Titolo("Prodotti ordinati per categoria e prezzo");
foreach (var p in sortedProductsByCategoryAndPrice)
{
    Console.WriteLine(p);
}
#endregion

#region order by custom comparer
string[] words2 = ["1 tigre", "2 cane", "5 albatros", "4 gatto", "3 zebra", "6 elefante"];
Logger.Titolo("Parole ordinate");
foreach (var word in words2.OrderBy(o => o, new IgnoraNumeriComparer()))
{
    Console.WriteLine(word);
}
#endregion

// take skip
#region take syntax
int[] numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];

var first3Numbers = numbers.Take(3);

Console.WriteLine(string.Join(" ", numbers.Take(3)));

var tuttiTranneIPrimi4 = numbers.Skip(4);

Logger.Titolo("Tutti tranne i primi 30");
Console.WriteLine(numbers.Skip(30).Count());
Console.WriteLine(string.Join(" ", numbers.Skip(30)));
#endregion

