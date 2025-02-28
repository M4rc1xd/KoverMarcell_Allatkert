using System;

namespace Allatkert
{
    internal class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            Allatkert a = new Allatkert(r.Next(5, 16));
            Console.Clear();
            a.telitettseg();
        }
    }
}