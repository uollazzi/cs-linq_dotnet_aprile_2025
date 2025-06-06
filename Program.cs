using System.Runtime.InteropServices;
using cs_linq;
using cs_linq.DataSource;
using cs_linq.Models;

// LINQ Language Integrated Query
Console.OutputEncoding = System.Text.Encoding.UTF8;

// I metodi di estensione consentono di "aggiungere" metodi ai tipi esistenti
// senza creare un nuovo tipo derivato, ricompilare o modificare in altro modo il tipo originale
// I metodi di estensione sono metodi statici, ma vengono chiamati come se fossero metodi di istanza nel tipo esteso. 
// I metodi di estensione più comuni sono gli operatori di query standard LINQ che aggiungono funzionalità di query
// ai tipi System.Collections.IEnumerable e System.Collections.Generic.IEnumerable<T> esistenti.

int[] ints = [10, 45, 15, 39, 21, 26];
var result = ints.OrderBy(o => o);

var asd = "ciao sono groot";
Console.WriteLine(asd.ToZigZag());
