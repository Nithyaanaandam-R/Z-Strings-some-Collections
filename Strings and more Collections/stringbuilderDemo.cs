using System.Diagnostics;
using System.Text;

public class stringbuilderDemo
{
    
    public static void Demo()
    {
        //STRINGBUILDER:

        string str1 = "Hello";
        string str2 = "Hello";

        Stopwatch stopwatch = Stopwatch.StartNew();

        for (int i = 0; i < 100; i++) //iterate forn 100000
            str1 = "Hello" + str1;
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds); //time taken to concat a string object

        //takes atleast 10k+ ms since there is creation and assignments ever iteration

        StringBuilder stringBuilder = new StringBuilder("Hello");

        stopwatch.Reset();
        stopwatch.Start();
        for (int i = 0; i < 100; i++)
            stringBuilder.Append("Hello");
        stopwatch.Stop();

        Console.WriteLine(stopwatch.ElapsedMilliseconds); //takes a few ms(<10) whileusing the stringbuilder

        //The stringbuilder essentially makes the changes directly in heap 

        stringBuilder.Clear();

        stringBuilder.Append("Hola Amigos");
        stringBuilder.Insert(5, "Tora ");

        Console.WriteLine(stringBuilder.ToString()); //Inserts string at said index

        stringBuilder.Replace("ola", "olea");
        Console.WriteLine(stringBuilder.ToString()); //replaces every occurence of first string with second string
    }
}