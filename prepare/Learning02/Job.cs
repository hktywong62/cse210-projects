// A code template for the category of things know as Job. The
// responsibility of a Job is to keep track of the company, job title, start year, and end year.

using System;
public class Job 
{
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear = 0;
    public int _endYear = 0;

    /** A special method
    public Job()
    {
    }**/
    
    // A method that displays the company's name, job title, start and end year
    public void Display()
    {
        Console. WriteLine($"{_jobTitle}  ({_company}) {_startYear}-{_endYear}");
    }
}
