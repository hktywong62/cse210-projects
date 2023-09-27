// A code template for the category of things know as Resume. The
// responsibility of a Job is to keep track of one's resume
using System;
using Microsoft.Win32.SafeHandles;
public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{_name}");
        foreach (Job job in _jobs)
        {
            job.Display();
        }


    }


}   