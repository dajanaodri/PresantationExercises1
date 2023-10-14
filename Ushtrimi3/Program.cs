class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a file path");

        string path = Console.ReadLine();

        try
        {
            string content = System.IO.File.ReadAllText(path);
            Console.WriteLine(content);
        }
        catch (ArgumentException exc)
        {
            Console.WriteLine("Path was not provided");
        }
        catch (PathTooLongException fe)
        {
            Console.WriteLine("Path is too long");
        }
        catch (DirectoryNotFoundException exc)
        {
            Console.WriteLine("Directory was not found");
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine("File was not found");
        }
        finally
        {
            Console.WriteLine("Thank you for using our app");
        }

        Console.ReadKey();
    }
}