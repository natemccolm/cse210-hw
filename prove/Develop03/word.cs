using System;
using System.Collections.Generic;
using System.IO;

public class Word {

    public string Text {get; private set;}
    public bool IsHidden {get; private set;}


    public Word(string text){
        Text=text;
        IsHidden=false;
    }

    public void Hide()
    {
        IsHidden=true;
        Text="_";
    }

    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }

    public void Unhide() {
    IsHidden = false;
    }

}