using System.Runtime.Serialization.Json;

[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Person object
        Person person = new Person { Name = "Alice", Age = 30 };

        // Serialize the object to a text file
        DataContractJsonSerializer serializer = 
            new DataContractJsonSerializer(typeof(Person));
        using (FileStream fileStream = new FileStream("person.txt", FileMode.Create))
        {
            serializer.WriteObject(fileStream, person);
        }

        // Deserialize the object from the text file
        using (FileStream fileStream = new FileStream("person.txt", FileMode.Open))
        {
            Person deserializedPerson = (Person)serializer.ReadObject(fileStream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, " +
                $"Age: {deserializedPerson.Age}");
        }

    }
}
