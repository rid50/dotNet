
using System.Text.RegularExpressions;
class Program
{
    static async Task Main(string[] args) {
        await GetString();
    }

    static readonly HttpClient _httpClient = new HttpClient();

    private static async Task<int> GetString()
    {
        //private static readonly HttpClient _httpClient2 = new HttpClient();
        // Capture the task handle here so we can await the background task later.
        var str =  _httpClient.GetStringAsync("https://dotnetfoundation.org");

        // The await operator suspends OnSeeTheDotNetsButtonClick(), returning control to its caller.
        // This is what allows the app to be responsive and not block the UI thread.
        var str2 = await str;
        //var str2 = str.Result;

        int count = Regex.Matches(str2, @"\.NET").Count;

        Console.WriteLine($"Number of .NETs on dotnetfoundation.org: {count}");
            
        return 0;
    }
}