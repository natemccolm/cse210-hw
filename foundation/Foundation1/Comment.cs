public class Comment {

    public string CommenterName {get; set;}
    public string Text {get; set;}

    public Comment(string commentername, string text){
        CommenterName=commentername;
        Text=text;
    }



}