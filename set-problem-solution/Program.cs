using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        List<string> list = new List<string>(){"Jake Adams", "Mark Jones", "Shalia Foster", "Luis Gonzalez", "Inter Miami", "Jake Adams", "Nicole Adams", 
        "Pixie Dust", "Shalia Foster", "Insure Does", "Luka Jokic"};

        HashSet<string> attendedSet = new HashSet<string>();
        HashSet<string> duplicateSet = new HashSet<string>();

        // Iterate through the list
        foreach (string s in list) {
            // If the attended set already contains the value, add it to the duplicate set
            if (attendedSet.Contains(s)){
                duplicateSet.Add(s);
            }
            // otherwise, add it to the attended set
            else {
                attendedSet.Add(s);
            }
        }

        // Print both sets
        Console.WriteLine($"Attended Class: {string.Join(',', attendedSet)}");
        Console.WriteLine($"Accidentally counted twice: {string.Join(',',duplicateSet)}");

    }
}
