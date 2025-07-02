using System.ComponentModel;

namespace CharacterCounting;
public class Program
{
    private static void Main(string[] args)
    {
        string filePath = "C:\\Users\\lyubo\\Desktop\\streams\\test.txt";
        Dictionary<char,int> frequency = new Dictionary<char, int>();
        using (StreamReader reader=new StreamReader(filePath))
        {
           int character;
            while ((character = reader.Read()) != -1)
            {
                char c = (char)character;
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }
        }
        foreach (KeyValuePair<char,int> kvp in frequency)
        {
            Console.WriteLine($"Character: '{kvp.Key}' - Frequency: {kvp.Value}");
        }
    }
}