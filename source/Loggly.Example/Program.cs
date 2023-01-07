using System;

namespace Loggly.Example {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            new Loggly.LogglyClient();
        }
    }
}