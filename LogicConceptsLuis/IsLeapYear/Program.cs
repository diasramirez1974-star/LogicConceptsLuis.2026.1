using Shared;
using System.ComponentModel.Design;
var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var currentYear = DateTime.Now.Year;
    var message = String.Empty;
    Console.WriteLine("Descubre si el año es biciesto o no");
    var year = ConsoleExtension.GetInt("Ingrese el año: ");
    if (year == currentYear)
    {
        message = "es";
    }
    else if (year > currentYear)
    {
        message = "será";
    }
    else
    {
        message = "fue";
    }
    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"El año {year}, Si {message} biciesto");
            }
            else
            {
                Console.WriteLine($"El año {year}, No {message} biciesto");

            }
        }
        else
        { 
            Console.WriteLine($"El año {year}, Si {message} biciesto");
        }
        
     
        
    }
    else
    {
        Console.WriteLine($"El año {year}, No {message} biciesto");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Has salido del programa");
