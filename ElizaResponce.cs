
using System;

namespace Eliza {
    class Eliza
        {
            public static string CreateElizaResponse(string clientStatement)
            {
                if (clientStatement.Contains("my"))
                {
                    int startIndex = clientStatement.IndexOf("my") + 3;
                    int endIndex = clientStatement.IndexOf(" ", startIndex);
                    string noun = endIndex != -1 ? clientStatement.Substring(startIndex, endIndex - startIndex) : clientStatement.Substring(startIndex);
                    return "Tell me more about your " + noun + ".";
                }
                else if (clientStatement.Contains("hate"))
                {
                    return "Why do you have these feelings!";
                }
            else if (clientStatement.Contains("love"))
            {
                return "You seem to have alot of love!";
            }
            else if (clientStatement.Contains("sad"))
            {
                return "I'm sorry to hear you are sad about that!";
            }
            else
                {
                    string[] responses = { "Please go on.", "Tell me more.", "Continue." };
                    Random rand = new Random();
                    return responses[rand.Next(0, responses.Length)];
                }
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your statement (or type 'exit' to quit): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;

                string response = Eliza.CreateElizaResponse(input);
                Console.WriteLine(response);
            }
        }
    }
}