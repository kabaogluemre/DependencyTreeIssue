using Newtonsoft.Json;
using System;

namespace DependencyTreeIssue.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serializedObject = JsonConvert.SerializeObject(new { Text = "Hello World!" });
            Console.WriteLine(serializedObject);
            Console.ReadLine();
        }
    }
}