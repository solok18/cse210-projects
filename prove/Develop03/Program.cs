using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference newReference = new Reference();
        newReference.SetBookName("Nephi");
        newReference.SetChapter("1");
        newReference.SetVerse("1");

        string sentence = "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.";
        newReference.SetContent(sentence);

        List<Word> wordList = new List<Word>();
        string[] words = sentence.Split(' ');
        for (int i = 0; i< words.Length; i++)
        {
            wordList.Add(new Word(words[i]));
        }
        
        Scripture scripture = new Scripture();
        scripture.SetReference(newReference);
        scripture.SetWordList(wordList);

        
        Reference reference = scripture.GetReference();
        List<Word> list = scripture.GetWordList();

        string book = reference.GetBookName();
        string chapter = reference.GetChapter();
        string verse = reference.GetVerse();
            

        Console.WriteLine($"{book} {chapter}: {verse} {sentence}");
        Console.WriteLine();
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

        Random random = new Random();
        for (int i = 0; i < list.Count; i++)
        {
            int randomIndex = random.Next(i, list.Count);
            Word radnomWords = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = radnomWords; 
        }

        int wordsHidden = 0;
        bool keepHiding = true;
        while (wordsHidden < list.Count && keepHiding)
        {
            string input = Console.ReadLine();
            if(input.ToLower() == "quit")
            {
                keepHiding = false;
            }
            else
            {
                int wordsThatWillHide = random.Next(3,4);

                for (int i = wordsHidden; i < wordsHidden + wordsThatWillHide && i <list.Count; i++)
                {
                    string word = list[i].GetWord();
                    int index = Array.IndexOf(words, word);
                    if (index >= 0 && index < words.Length)
                    {
                        words[index] = scripture.WordsHidden(words[index]);
                    }

                }
                wordsHidden += wordsThatWillHide;
                string updatedSentence = string.Join(" ", words);
                Console.Clear();
                Console.WriteLine($"{book} {chapter}: {verse} {updatedSentence}");
                Console.WriteLine();
                Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            }
        }
    }   
}