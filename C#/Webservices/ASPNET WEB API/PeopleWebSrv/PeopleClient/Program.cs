using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PeopleClient
{
    class Person
    {
        public int Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main()
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/MyPeopleSrv/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //HTTP GET
                Console.WriteLine("Retreive all people:\n");
                JArray people = getAllPeople();
                foreach (var p in people)
                {
                    Console.WriteLine(p);
                }


                //HTTP GET
                Console.WriteLine("Retreive a Person by ID:\n");
                JObject person = getPerson(3);
                Console.WriteLine(person);


                //HTTP POST
                Console.WriteLine("Adding a Person:\n");
                person = AddPerson("Mohit", "Batra");
                Console.WriteLine(person);

                //HTTP PUT
                Console.WriteLine("Updating a Person by ID:\n");
                UpdatePerson(2, "Sanath", "Kumar");


                //HTTP DELETE
                Console.WriteLine("Deleting a Person by ID:\n");
                DeletePerson(3);

                //HTTP GET
                Console.WriteLine("Retreive all people:\n");
                people = getAllPeople();
                foreach (var p in people)
                {
                    Console.WriteLine(p);
                }
                Console.ReadLine();
            }
        }

        static JArray getAllPeople()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                client.GetAsync("http://localhost/MyPeopleSrv/api/person/getallpeople/").Result;
            return response.Content.ReadAsAsync<JArray>().Result;
        }


        // Sends HTTP GET to Person Controller on API with ID:
        static JObject getPerson(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                client.GetAsync("http://localhost/MyPeopleSrv/api/person/getperson/" + id).Result;
            return response.Content.ReadAsAsync<JObject>().Result;
        }

        // Sends HTTP POST to Person Controller on API with Anonymous Object:
        static JObject AddPerson(string newLastName, string newFirstName)
        {
            // Initialize an anonymous object representing a new Person record:
            var newPerson = new { LastName = newLastName, FirstName = newFirstName };

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost/MyPeopleSrv/");
            var response = client.PostAsJsonAsync("api/person/AddPerson/", newPerson).Result;
            return response.Content.ReadAsAsync<JObject>().Result;
        }


        // Sends HTTP PUT to Person Controller on API with Anonymous Object:
        static bool UpdatePerson(int personId, string newLastName, string newFirstName)
        {
            // Initialize an anonymous object representing a the modified Person record:
            var newPerson = new { id = personId, LastName = newLastName, FirstName = newFirstName };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost/MyPeopleSrv/");
            var response = client.PutAsJsonAsync("api/person/UpdatePerson/", newPerson).Result;
            return response.Content.ReadAsAsync<bool>().Result;
        }

        // Sends HTTP DELETE to Person Controller on API with Id Parameter:
        static void DeletePerson(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost/MyPeopleSrv/");
            var relativeUri = "api/person/DeletePerson/" + id.ToString();
            var response = client.DeleteAsync(relativeUri).Result;
            client.Dispose();
        }
    }
}
