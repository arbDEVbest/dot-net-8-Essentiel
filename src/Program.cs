namespace Dates;

class Program
{
    static void Main(string[] args)
    {
        DateTimeOffset début = new(year: 2024, month: 02, day: 22, hour: 08, 0, 0, TimeSpan.FromHours(1));
        TimeSpan durée = new(hours: 1, minutes: 30, 0);
        var fin = début + durée;
        var attente = début - DateTime.Now;

        Console.WriteLine($"RDV {début} à {fin} dans {attente}");
    }
}
