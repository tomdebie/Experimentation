namespace Experimentation.Console;

using System;
using ExperimentationApi.Client;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Task.Run(() => Task.FromResult(MainAsync(args))).GetAwaiter().GetResult();
        }
    }

    static async Task MainAsync(string[] args)
    {
        Console.WriteLine("Press any key to start!");
        Console.ReadKey();

        var client = new Client("https://localhost:7179", new HttpClient());
        var userDto = new UserDto("email", "name", "password");
        try
        {
            await client.CreateUserAsync(userDto);
        }
        catch (ApiException<ValidationProblemDetails> ex)
        {
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine("Press any key to quit!");
        Console.ReadKey();
    }
}