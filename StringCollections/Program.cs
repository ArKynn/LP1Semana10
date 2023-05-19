using System.Collections;

namespace StringCollections;

public class Program
{
    public static void Main()
    {
        string str1 = "YOO";
        string str2 = "Nyaaa";
        string str3 = "YESS";
        string str4 = "Let's Go!";
        string str5 = str1;
        
        var stringlist = new List<string> { str1, str2, str3, str4, str5 };
        var stringHashSet = new HashSet<string>{str1, str2, str3, str4, str5};
        var stringStack = new Stack<string>();
        stringStack.Push(str1);
        stringStack.Push(str2);
        stringStack.Push(str3);
        stringStack.Push(str4);
        stringStack.Push(str5);
        var stringQueue = new Queue<string>();
        stringQueue.Enqueue(str1);
        stringQueue.Enqueue(str2);
        stringQueue.Enqueue(str3);
        stringQueue.Enqueue(str4);
        stringQueue.Enqueue(str5);
    }
}
