using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        CollectionsDemo.Demo(); //Refer CollectionsDEmo.cs

        int value = 15;

        unsafe
        {
            Console.WriteLine((int)&value);
        }

        value = 123;
        unsafe
        {
            Console.WriteLine((int)&value); //both occupy same memory in the stack
        }

        //As such the value type data is stored in stack memory 

        //Reference types such as string, store the reference at stack while the actual data is at heap 

        string str1 = "Hello";
        string str2 = "Hello";

        unsafe
        {
            char p = str1[0];
            Console.WriteLine((int)&p); //both occupy same memory in the stack
        }

        Console.WriteLine(str1 == str2); //since string is a reference type, both str1 and str2 point or refer to the same address of "Hello"

        str1 = "hello"; //here a new string "hello" is created and the reference to that is set to str1 

        unsafe
        {
            char p = str1[0];
            Console.WriteLine((int)&p); //after changing you can see change in memory address
        }

        // As such strings are immutable in the sense their value don't get changed instead, they change where they point to 

        str2 = "hello";
        Console.WriteLine(str1 == str2); //this again returns true

        //the string "Hello"that was initially created and used will be later collected by the 
        //Garbage collecter duing it's routine

        /*--------- String Interpolation -------*/

        str1 = "Hola";
        Console.WriteLine(@"{0}, Please enter your name", str1);
        var name = Console.ReadLine();

        Console.WriteLine($"{str1} {name}! This is a string that allows interpolation.");
        str2 = $"You can also interpolate this way {name}. And even {"give alignment",20}. Or basically execute any expression {2+3} {2>3} ";

        Console.WriteLine(str2);

        //Now Verbatim string has been used here. 

        str1 = "This line has \t (tab) and \n (nextline) escape characters" ;

        //so when u print - they are executed

        Console.WriteLine(str1);

        str2 = @"This line has \t (tab) and \n (nextline) escape characters";
        Console.WriteLine(str2 + "But prints them all and doesn't treat as escape chars");

        Console.Read();
        Console.Clear();

        Console.WriteLine("Let's see Stringbuilder");// jump to string builder
        stringbuilderDemo.Demo();
    }

}
