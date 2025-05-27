using cs_linq.DataSource;

// LINQ Language Integrated Query
Console.OutputEncoding = System.Text.Encoding.UTF8;

var customers = Customers.CustomerList;
Console.WriteLine($"Customers: {customers.Count}");

var categories = Products.CategoryList;
Console.WriteLine($"Categories: {categories.Count}");

var products = Products.ProductList;
Console.WriteLine($"Products: {products.Count}");

// linq ha 2 tipi di sintassi
// 1. Sintassi di Query (un po' più leggibile)
// 2. Sintassi di metodo (più completa)
int[] numbers = { 5, 10, 8, 3, 6, 12 };

// tornare tutti i numeri pari ordinati

// SELECT s.num FROM numbers s WHERE ISPARI(s.num) ORDER BY s.n
// Sintasi di Query (Query Syntax)
var numQuery1 = from num in numbers
                where num % 2 == 0
                orderby num
                select num;

// Sintassi di metodo (Method Syntax)
var numQuery2 = numbers
                .Where(num => num % 2 == 0)
                .OrderBy(o => o);

Logger.Titolo("Query Syntax");
foreach (var n in numQuery1)
{
    Console.Write(n + " ");
}
Console.Write(Environment.NewLine);


Logger.Titolo("Method Syntax");
foreach (var n in numQuery2)
{
    Console.Write(n + " ");
}
Console.Write(Environment.NewLine);

// INTERFACCE
// La sintassi Linq si applica a qualsiasi oggetto C# che implmenti
// IEnumerable o IQueryable (e derivate es: IOrderedEnumerable)
// e spesso ritorna IEnumerable o IQueryable affinchè possiamo concatenare istruzioni
// IEnumerable si applica ad oggetti caricati in memoria
// IQueryable si applica a Database

Logger.Titolo("Ricerca film");
var movies = Movies.GetMovies();

var darkKnight = movies.Find(m => m.Preview.Title == "The Dark Knight");
Console.WriteLine(darkKnight.Preview.FullTitle);