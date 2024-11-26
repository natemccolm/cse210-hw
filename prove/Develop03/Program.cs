//Multiple verses added to the program, rather than just the one

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world that he gave his one and only Son.");
        List<string> Verses=new List<string>();
        Verses.Add("Trust in the LORD with all thine heart; and lean not unto thine own understanding.");
        Verses.Add("In all thy ways acknowledge him, and he shall direct thy paths.");
        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture2 = new Scripture(reference2, Verses);
        Reference reference3 = new Reference("Ethere", 11, 4);
        Scripture scripture3 = new Scripture(reference3, "And he lived to a good old age, and begat Shiblom; and Shiblom reigned in his stead. And the brother of Shiblom rebelled against him, and there began to be an exceedingly great war in all the land..");

        List<Scripture> ScriptureList=new List<Scripture>();
        ScriptureList.Add(scripture1);
        ScriptureList.Add(scripture2);
        ScriptureList.Add(scripture3);
        Random rnd= new Random();
        int r=rnd.Next(ScriptureList.Count);

        Scripture scripture=ScriptureList[r];



        while (true)
        {
            // Display the scripture (without clearing the screen yet)
            scripture.Display();

            // Check if all words are hidden
            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break; // Exit the loop if all words are hidden
            }

            // Prompt the user for input (this allows typing 'quit' or pressing Enter)
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit");

            // Capture user input
            string input = Console.ReadLine();

            // If the user types 'quit', break the loop
            if (input.ToLower() == "quit")
            {
                break;
            }


            // Hide 3 more words each time Enter is pressed
            scripture.HideWords(3);

            // After hiding words, clear the screen before the next display
            Console.Clear();
        }
    }
}

