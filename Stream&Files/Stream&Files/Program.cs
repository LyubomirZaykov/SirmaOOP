using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Text;

namespace StreamAndFiles;
public class Program
{
    private static void Main(string[] args)
    {
      string filePath = "C:\\Users\\lyubo\\Desktop\\streams\\test.txt";

      StreamReader reader = new StreamReader(filePath);
        //using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        //{
        //    byte[] buffer = new byte[64];
        //    int bytesRead;
        //    int i = 0;
        //    while ((bytesRead=stream.Read(buffer,0,buffer.Length)) > 0)
        //    {
        //        string content = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        //        Console.WriteLine("buffer" +i);
        //        Console.WriteLine(content);
        //        i++;
        //    }
        //}

        //string newFilePath = "C:\\Users\\lyubo\\Desktop\\streams\\newFilePath.txt";
        //using (FileStream fileStream=new FileStream(newFilePath, FileMode.Create, FileAccess.Write))
        //{
        //    byte[] dataToWrite=System.Text.Encoding.UTF8.GetBytes("Hello, C# streams!");

        //    fileStream.Write(dataToWrite, 0, dataToWrite.Length);

        //}
        //string newFilePath1 = "C:\\Users\\lyubo\\Desktop\\streams\\newFilePath1.txt";
        //FileStream fileStream = new FileStream(newFilePath1, FileMode.Create, FileAccess.Write);
        //byte[] data=System.Text.Encoding.UTF8.GetBytes("Text written with 'Flush' command");
        //fileStream.Write(data, 0, data.Length);
        ////fileStream.Flush();
        //Console.WriteLine("Data flushed to the file");


        //using (MemoryStream memoryStream = new MemoryStream())
        //{
        //    byte[] data = System.Text.Encoding.UTF8.GetBytes("C# Stream position example");
        //    memoryStream.Write(data, 0, data.Length);

        //    Console.WriteLine("Stream Length: " +memoryStream.Length);
        //    memoryStream.Position = 0; // Reset position to the beginning of the stream
        //    byte[] buffer = new byte[memoryStream.Length]; 
        //    memoryStream.Read(buffer,0, buffer.Length);

        //    string text = System.Text.Encoding.UTF8.GetString(buffer);
        //    Console.WriteLine("Read Content: " +text);

        //    Console.WriteLine("Final Position: " + memoryStream.Position);

        //}
        //string[] text1 = File.ReadAllLines(filePath);
        //string text=File.ReadAllText(filePath);

        //Console.WriteLine(text);

        //foreach (string line in text1)
        //{
        //    Console.WriteLine(line);
        //}
        string moveDir = "C:\\Users\\lyubo\\Desktop\\streams\\substreams\\dir1";

        string destDir = "C:\\Users\\lyubo\\Desktop\\streams\\substreams\\dir2";
        Directory.CreateDirectory(moveDir);
        //Directory.CreateDirectory(destDir);

        Directory.Move(moveDir, destDir);


    }
}