using json_dz6;
using System.Text;
using System.Text.Json;

namespace DZ6_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            try
            {
                string path = "C:\\Users\\USER\\Documents\\GitHub\\OOP_HolovaAnastasiia_K-27\\json_dz6\\jsconfig1.json";
                string json = File.ReadAllText(path);
                List<Book>? books = JsonSerializer.Deserialize<List<Book>>(json);

                foreach (var book in books ?? Enumerable.Empty<Book>())
                {
                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"Publishing house: {book.PublishingHouse?.Name}");
                    Console.WriteLine($"Publishing house id: {book.PublishingHouseId}");
                    Console.WriteLine($"Publishing house adress: {book.PublishingHouse?.Adress}");
                    Console.WriteLine();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File is not found");
            }
            catch (JsonException)
            {
                Console.WriteLine("Deserialisation error");
            }

            Console.ReadKey();
        }
    }
}