using System;
using System.Collections.Generic;
using System.IO;

public class Scripture {

    private Reference Reference {get; set;}
    private List<Word> Words {get; set;}


    public Scripture(Reference reference, string text){

        Reference=reference;
        Words=new List<Word>();


    foreach (string word in text.Split(' ')){
        Words.Add(new Word(word));
        
    }
    }

    public Scripture(Reference reference, List<string> verses){
        Reference=reference;
        Words=new List<Word>();
            foreach (string verse in verses){
                    foreach (string word in verse.Split(' ')){
                Words.Add(new Word(word));}
            }
    }

    public void Display(){

        Console.WriteLine(Reference.ToString());
        foreach (Word word in Words)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
    }

public void HideWords(int count)
{
    int hidden = 0;
    Random random = new Random();

    while (hidden < count)
    {
        int index = random.Next(Words.Count);
        if (!Words[index].IsHidden)
        {
            Words[index].Hide(); 
            Console.WriteLine($"Word hidden: {Words[index].Text}");  
            
        }
        else{
            bool wordsVisible=false;
            foreach (Word word in Words){
                if(word.IsHidden){
                    continue;
                }
                else{
                    wordsVisible=true;
                }
            }
            if (wordsVisible){
                continue;
            }
            else{
                break;
            }

        }
        hidden++;  
    }
}

    public bool AreAllWordsHidden()
    {
        return Words.TrueForAll(word=>word.IsHidden);
    }
}