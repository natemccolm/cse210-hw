using System;
using System.Collections.Generic;
using System.IO;

public class Reference 
{
    public string Book {get;private set;}
    public int Chapter {get;private set;}
    public int StartVerse {get;private set;}
    public int? EndVerse {get;private set;}

    public Reference(string book, int chapter, int startVerse)

        {
            Book=book;
            Chapter=chapter;
            StartVerse=startVerse;
            EndVerse=null;
        }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book=book;
        Chapter=chapter;
        StartVerse=startVerse;
        EndVerse=endVerse;
    }

    public override string ToString()
    {
        return EndVerse == null
            ? $"{Book} {Chapter}:{StartVerse}"
            : $"{Book} {Chapter}:{StartVerse}--{EndVerse}";

    }
}