internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "C:\\Users\\lyubo\\Desktop\\streams\\input.txt";
        string outputFile = "C:\\Users\\lyubo\\Desktop\\streams\\output.txt";


        string content = File.ReadAllText(filePath);
        string output=content.Replace("HTML", "C#");

        File.WriteAllText(outputFile,output);
    }
}