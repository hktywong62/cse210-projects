using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string choice = "0";
        do
        {

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do?  ");
        choice = Console.ReadLine();

        if (choice == "1")
        {
            journal.AddEntry();
        }
        if (choice == "2")
        {
            journal.Display();
        }
        if (choice == "3")
        { 
            journal.LoadFile();
        }
        if (choice == "4")
        {
            journal.SaveFile();
        } 
    }
        while(choice != "5");
    }
}