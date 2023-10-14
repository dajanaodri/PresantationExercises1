using System;
using System.ComponentModel;
using System.Reflection;

public class Person
{
    [DisplayName("Emri")]
    public string FirstName { get; set; }

    [DisplayName("Mbiemri")]
    public string LastName { get; set; }

    [DisplayName("Mosha")]
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        var person = new Person
        {
            FirstName = "Dajana",
            LastName = "Odri",
            Age = 26
        };

        var type = person.GetType();
        var properties = type.GetProperties();

        foreach (var property in properties)
        {
            var displayNameAttribute = property.GetCustomAttribute<DisplayNameAttribute>();

            if (displayNameAttribute != null)
            {
                Console.WriteLine($"{displayNameAttribute.DisplayName}" +
                    $": {property.GetValue(person)}");
            }
            else
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(person)}");
            }
        }
    }
}
