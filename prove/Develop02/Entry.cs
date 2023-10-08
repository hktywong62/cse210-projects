using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

public class Entry 
{
    public string _entryTime = "";
    public string _prompt = "";
    public string _textEntry = "";

    public Entry(){
    }

    public List<Entry> entries = new List<Entry>();
}


