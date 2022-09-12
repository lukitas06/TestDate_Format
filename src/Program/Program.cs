namespace TestDateFormat;

/// <summary>
/// El programa principal.
/// </summary>
public static class Program
{
    /// <summary>
    /// Punto de entrada al programa principal.
    /// </summary>
    public static void Main()
    {
        string testDate = "1/11/19975656";
        string date= DateFormatter.ChangeFormat(testDate);
        if (date!=""){
            Console.WriteLine($"{testDate} se convierte a {date}");
        }
        if (date==""){  
            Console.WriteLine($"Invalid date. Can not be converted");
        }
            
    }
}