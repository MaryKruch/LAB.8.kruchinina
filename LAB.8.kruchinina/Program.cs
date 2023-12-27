//medium.lvl.№11
using System.Globalization;
try
{

    Console.Write("Введите количесиво киносеансов:");
    int n = int.Parse(Console.ReadLine());
    Afisha[] afishas = new Afisha[n];
    for (int i = 0; i < n; i++)
    {
        afishas[i] = new Afisha();
        Console.Write("Название кинотеатра: ");
        afishas[i].NameOfCinema = Console.ReadLine();
        Console.Write("Название фильма: ");
        afishas[i].NameOfFilm = Console.ReadLine();
        Console.Write("Жанр: ");
        afishas[i].genre = Console.ReadLine();
        Console.Write("Дата и время начала киносеанса (в формате 'ДД.ММ.ГГГГ ЧЧ:ММ'): ");
        afishas[i].StartTimeAndData = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Длительность в минутах: ");
        afishas[i].DurationInMinutes = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
    {
        DateTime TimeOfEnd = afishas[i].StartTimeAndData.AddMinutes(afishas[i].DurationInMinutes);
        Console.WriteLine($"Киносеанс №{i + 1} завершится в {TimeOfEnd:HH:mm}");
    }
    
for (int i = 0; i <n; i++)
    {
        DayOfWeek w = afishas[i].StartTimeAndData.DayOfWeek;
        if (w == DayOfWeek.Saturday || w == DayOfWeek.Sunday)
        {
            Console.WriteLine($"Фильм '{afishas[i].NameOfFilm}' идет в выходные дни");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
struct Afisha
{
    public string NameOfCinema;
    public string NameOfFilm;
    public string genre;
    public DateTime StartTimeAndData;
    public int DurationInMinutes;

}