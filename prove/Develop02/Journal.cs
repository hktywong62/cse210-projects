using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;


public class Journal
{
    
    public List<Entry> _entries = new List<Entry>();


        // journal.AddEntry()

    public void AddEntry()
    {

        List<string> promptings = new List<string>();

        promptings.Add("Who was the most interesting person I interacted with today?");
        promptings.Add("What was the best part of my day?");
        promptings.Add("How  did I see the hand of the Lord in my life today?");
        promptings.Add("What was the best part of talk given by President Nelson in this General Conference?");
        promptings.Add("What was the strongest emotion I felt today?");
        promptings.Add("If I had one thing I could do over today, what would it be?");
        promptings.Add("If you are happy today, think of the reasons");
            
        // Random Generator

        Random randomMachine = new Random();
        int RandomNumber = randomMachine.Next(promptings.Count);

        Console.WriteLine(promptings[RandomNumber]);

        //string _textEntry = Console.ReadLine();
            
        // set the time object 
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();  

        // set up instance for new entry

        
        Entry entry = new Entry();

        entry._entryTime = dateText;
        entry._prompt = promptings[RandomNumber];

        // allow the user to write entry
        Console.Write(">");
        entry._textEntry = Console.ReadLine();

        _entries.Add(entry);

   }
        // journal.Display();

        public void Display()
        {
            
            /* foreach(Entry entry in entry)

            {
               Console.WriteLine($"Time: {entry._entryTime} - Prompt:{entry._prompt} {entry._textEntry}");
            
            }*/
            Console.WriteLine("{entry._entryTime}, {entry._prompt}");

            Console.WriteLine();
 
        }

        // journal.LoadFile();
        
        public void LoadFile()
        {
            Console.Write("Please provide the filename:  ");
            string LoadFile = Console.ReadLine();
            //try
            {
                string[] lines = File.ReadAllLines(LoadFile);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
           /* catch(FileNotFoundException)
            {
                Console.WriteLine("File not found: " + LoadFile);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: "+e.Message);
            }*/

            Console.WriteLine("The loading is successful");
        }

        // journal.Savefile();

        public void SaveFile()
        {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry e in _entries){
                    Console.WriteLine($"{e._entryTime} |{e._prompt}|{e._textEntry}");
                }
            
            }
           Console.WriteLine("Entries saved to " + filename); 
        }
}
