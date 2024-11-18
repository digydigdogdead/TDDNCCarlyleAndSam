namespace TDDProject
{
    public class WordAnalyser
    {
        public List<string> FindLongestWords(string text)
        {
            // TODO: Implement the logic to find the longest word(s) in the given text

            string[] stringArray = text.Split(' ');

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i].Trim([' ', '.']);
            }

            int longestWordLength = 0;

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > longestWordLength)
                {
                    longestWordLength = stringArray[i].Length;
                }
            }

            var result = stringArray.Where(word =>  word.Length == longestWordLength).ToList();

            return result;


        }

        public Dictionary<char, int> CalculateLetterFrequency(string text)
        {
            // TODO: Implement the logic to calculate the frequency of each letter in the given text

            text = text.ToLower();

            Dictionary<char, int> letterFrequencies = new Dictionary<char, int>();

            int startingIndex = (int)'a';
            int endingIndex = (int)'z';

            for (int i = startingIndex; i <= endingIndex; i++)
            {
                letterFrequencies.Add((char)i, 0);
            }

            foreach (char c in text)
            {
                if (letterFrequencies.ContainsKey(c))
                {
                    letterFrequencies[c]++;
                }
            }

            return letterFrequencies;
        }
    }
}
