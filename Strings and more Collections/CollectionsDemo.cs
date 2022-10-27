public class CollectionsDemo
{
    public static void Demo()
    {
        List<string> fruits = new List<string>{ "apple", "banana", "mango", "orange",
                      "passionfruit", "grape" };
        Console.WriteLine("Size of fruit list = " + fruits.Count);

        Stack<string> stack = new Stack<string>(fruits);

        stack.Push("Dragonfruit");
        Console.WriteLine("Converted stack size after push " + stack.Count);

        /*
         * This conversion is not possible implicitly.
         * It works because of IEnumerbale interface which is accepted as argument for stack constructor
         * It returns a iteration of collection of variables
        */        

        List<int> values = new List<int> { 1,2,3,4,5,6,7,8,9,0};

        foreach(int val in values)
        {
            stack.Push(Convert.ToString(val));
        }

        //Covariance & Contravariance

        IEnumerable<String> strings = new List<String>
        {
            "abs", "def", "ghi"
        }; //Object instantiated with more derived type argument - List is a derived class from Inumerable interface
        
        //is assigned to
        
        IEnumerable<Object> objects = strings; //object instantiated with less dervied argument - object is the parent class od all types

        //Covariance preserves assignment capability

        Console.WriteLine(objects.ToList()[0]);

        Console.Read();
    }
}