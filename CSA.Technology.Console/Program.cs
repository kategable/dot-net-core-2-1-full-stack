using Flurl;
using Flurl.Http;

namespace CSA.Technology.Console
{
    class Program
    {
        static void Main(string[] args)
        {        
            var result = "https://localhost:44341"
                .AppendPathSegments("api")
                .AppendPathSegments("message").GetStringAsync().Result;
            System.Console.WriteLine(result);
            System.Console.ReadLine();
        }
    }
}
