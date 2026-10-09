using System;
using System.Net.Http;
using System.Threading.Tasks;

class Project
{
    static async Task Main(string[] args)
    {
        using var client = new HttpClient();
        
        try
        {
            string webPageContent = await client.GetStringAsync("www.eaglercraft.dev");
            Console.WriteLine(webPageContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}