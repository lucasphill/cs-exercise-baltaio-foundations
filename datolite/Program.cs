
using System.Globalization;

Console.Clear();
var date = DateTime.Now;
DateTime? nulldate = DateTime.Now;

Console.WriteLine(new DateTime());
Console.WriteLine(DateTime.Now);
Console.WriteLine(new DateTime(2010, 12, 31, 13, 33, 22));
Console.WriteLine(date.Year);
Console.WriteLine((int)date.DayOfWeek);
Console.WriteLine(date.DayOfWeek);
Console.WriteLine(date.DayOfYear);
Console.WriteLine($"Ano {date:yyyy}");
Console.WriteLine($"Data com fração de segundo {date:yyyy-mm-dd fffffff}");
Console.WriteLine($"padrão rfc {date:r}");
Console.WriteLine($"Nosql {date:s}");
Console.WriteLine($"json {date:u}");

Console.WriteLine(date.AddDays(15));
Console.WriteLine(date.AddYears(15));

if (date.Date == DateTime.Now.Date)
{
    Console.WriteLine("é igual");
}

var pt = new CultureInfo("pt-BR");
var us = new CultureInfo("en-US");
var uk = new CultureInfo("en-UK");
var de = new CultureInfo("de-DE");
var atualCulture = CultureInfo.CurrentCulture;

Console.WriteLine($"{date.ToString("D", de)}");
Console.WriteLine($"{date.ToString("D", pt)}");
Console.WriteLine($"{date.ToString("D", atualCulture)}");

var utc = DateTime.UtcNow; //sem timezone nenhum, para utilizar no servidor
Console.WriteLine(utc);
Console.WriteLine(utc.ToLocalTime());

var timeZoneUser = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
Console.WriteLine(timeZoneUser);

var utcDate = DateTime.UtcNow;

var timezones = TimeZoneInfo.GetSystemTimeZones();
foreach (var timezone in timezones)
{
    Console.WriteLine(timezone.Id);
    Console.WriteLine(timezone);
    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
    Console.WriteLine("----------");
}

Console.WriteLine(new TimeSpan(10000001)); //tempo a partir de milésimos de segundos (ms)
Console.WriteLine(new TimeSpan(5, 12, 33));