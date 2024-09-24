using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace KlientAPI
{
    class Program
    {
        private static readonly HttpClient HttpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5257/api/Person/") };

        static async Task Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Get Persons");
            Console.WriteLine("2. Get Person By Id");
            Console.WriteLine("3. Add Person");
            Console.WriteLine("4. Get Random Integers");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    await GetPersons();
                    break;
                case "2":
                    await GetPersonById();
                    break;
                case "3":
                    await AddPerson();
                    break;
                case "4":
                    await GetRandomIntegers();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        private static async Task GetPersons()
        {
            try
            {
                var persons = await HttpClient.GetFromJsonAsync<List<Person.Models.Person>>("getPersoner");
                foreach (var person in persons)
                {
                    Console.WriteLine(person.Name + " " + person.Age);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }

        private static async Task GetPersonById()
        {
            try
            {
                Console.Write("Enter Person Id: ");
                var id = int.Parse(Console.ReadLine());
                var person = await HttpClient.GetFromJsonAsync<Person.Models.Person>($"getPersonById?id={id}");
                Console.WriteLine(person?.ToString() ?? "Person not found");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }

        private static async Task AddPerson()
        {
            try
            {
                var newPerson = new Person.Models.Person { Id = 3, Name = "Console Person", Age = 30 };
                var response = await HttpClient.PostAsJsonAsync("addPerson", newPerson);
                var addedPerson = await response.Content.ReadFromJsonAsync<Person.Models.Person>();
                Console.WriteLine(addedPerson?.ToString() ?? "Failed to add person");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }

        private static async Task GetRandomIntegers()
        {
            try
            {
                var response = await HttpClient.GetStringAsync("https://www.random.org/integers/?num=10&min=1&max=6&col=1&base=10&format=plain&rnd=new");
                Console.WriteLine("Random Integers:");
                Console.WriteLine(response);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}