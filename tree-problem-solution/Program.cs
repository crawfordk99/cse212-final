using System.Collections.Generic;
using tree_problem_solution;

class Program(){
    static void Main(string[] args){
        BinarySearchTree tree = new BinarySearchTree();
        List<int> list = new List<int>(){7629011, 1351359, 5910101, 5010959, 15910010, 
        9501001, 1001010, 9910590, 
        1090100, 1759819, 0595018, 1750111};
        Console.WriteLine("Enter the 7 digits after the area code you're looking for");
        string userInput = Console.ReadLine();
        int userNum = int.Parse(userInput);

        DateTime startTime = DateTime.Now;
        list.Contains(userNum);
        DateTime endTime = DateTime.Now;
        TimeSpan timeElapsed = endTime - startTime;
        Console.WriteLine($"List search: {timeElapsed.ToString()}");
        foreach (int item in list){
            tree.Insert(item);
        }
        startTime = DateTime.Now;
        tree.Contains(userNum);
        timeElapsed = DateTime.Now - startTime;
        Console.WriteLine(tree.ToString());
        Console.WriteLine($"Tree Search: {timeElapsed.ToString()}");


    }
}