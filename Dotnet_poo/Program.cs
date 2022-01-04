using System;
using Dotnet_poo.Src.Entities;

namespace Dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
             Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
           
           
           Console.WriteLine("-----------------------------------");
           Console.WriteLine(arus);
           Console.WriteLine(arus.Attack());

           Console.WriteLine("-----------------------------------");

           Console.WriteLine(wizard);
           Console.WriteLine(wizard.Attack(7));
           Console.WriteLine(wizard.Attack(1));
           
        }
    }
}
