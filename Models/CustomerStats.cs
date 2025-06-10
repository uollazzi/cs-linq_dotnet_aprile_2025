namespace cs_linq.Models;

public class CustomerStats
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal TotaleAcquistato { get; set; }
    public int NumeroOrdini { get; set; }
}