using System;
using Flurl;
using Flurl.Http;

namespace multy.layer.console
{
    class Program
    {
        static void Main(string[] args)
        {        
            var result = "https://localhost:44341"
                .AppendPathSegments("api")
                .AppendPathSegments("values", 2).GetStringAsync().Result;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
