using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace AlgoSorting
{
    class Program
    {
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetTodoItems();
        }
        private async Task GetTodoItems()
        {
            string response = await client.GetStringAsync(
                "http://jsonplaceholder.typicode.com/todos");

            Console.WriteLine(response);

            List<Todo> todo = JsonConvert.DeserializeObject<List<Todo>>(response);
            foreach (var item in todo)
            {
                Console.WriteLine(item.title);
            }
        }
        class Todo
        {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public bool completed { get; set; }
        }
 
    }
}