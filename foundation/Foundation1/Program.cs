using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        
            Video video1 = new Video("Insert Title 1", "Mary Sue", 180);
            Video video2 = new Video("Insert Title 2", "Gary Stu", 240);

            video1.Comments.Add(new Comment("Alice", "Moo."));
            video1.Comments.Add(new Comment("Bob", "Moo2."));
            video1.Comments.Add(new Comment("Charlie", "Moo3."));
            
            video2.Comments.Add(new Comment("David", "Moo4."));
            video2.Comments.Add(new Comment("Eva", "Moo5."));

            DisplayVideoDetails(video1);
            DisplayVideoDetails(video2);

    }

    static void DisplayVideoDetails(Video video){

        Console.WriteLine($"Title: {video.Title}");
        Console.WriteLine($"Author: {video.Author}");
        Console.WriteLine($"Length: {video.Length}");
        Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
        Console.WriteLine("Comments: ");

        foreach (var comment in video.Comments){
            Console.WriteLine($"-{comment.CommenterName}: {comment.Text}");
        }
        
            
        


    }

}