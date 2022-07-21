// Top-Level Statements in .NET6-Konsole

// Ersetzt durch global using in Usings.cs
//using EierfarmDal;

Huhn hilde = null; // Warning für Null-Zuweisung
// Huhn hilde = null!; // Mit ! keine Warning mehr (! = "Null enforcement")

Console.WriteLine($"Das Huhn heißt {hilde.Name}"); // Warning: Maybe null
Console.WriteLine($"Das Huhn heißt {hilde?.Name}");

if (hilde != null)
{
    Console.WriteLine($"Das Huhn heißt {hilde.Name}"); // keine Warning

    Huhn herta = hilde;

    Console.WriteLine($"Das 2. Huhn heißt {herta.Name}"); // keine Warning
}

#nullable disable // Lokales Deaktivieren der null-Prüfung
Huhn hanne = hilde; // keine Warning, weil abgeschaltet

Console.WriteLine($"Das 3. Huhn heißt {hanne.Name}"); // Laufzeit-Exception hier 
#nullable enable

// Projektweite Steuerung der Nullable-Prüfung in csproj (<Nullable>enable|disable</Nullable>)



// Fragezeichen als Syntaxbestandteil
//int a;
//a = GetDatabaseValue();

//int GetDatabaseValue()
//{
//    object dbValue = ReadFromDb();

//    if (dbValue == null)
//    {
//        return -1;
//    }
//    return Convert.ToInt32(dbValue);
//}

System.Nullable<int> a1; // Integer, der NULL akzeptiert
int? a2 = null;
int b1 = a2.HasValue ? a2.Value : -1; // Dim b1 as Integer = IIf(a2.HasValue, a2.Value, -1)
int b2 = a2 ?? -1; // Kurzform für obige Zeile

// NUll-Prüfung inline:
Console.WriteLine($"Das 3. Huhn heißt {hanne?.Name}"); // Hanne = null? Abbruch der Anweisung an dieser Stelle, hanne?.Name gibt null zurück
