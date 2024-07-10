using System;

class Program(){
    static void Main(string[] args){
        string userInput = "";

        // Create a queue object
        Queue<string> myQueue = new Queue<string>();
        Console.WriteLine("Please enter in assignments. Press enter when done. ");
        // Use while loop to enter assignments and add to the queue

        while (true) {
            userInput = Console.ReadLine();
            if (userInput == "") {
                break;
            }
            // Add to queue if count is under 10
            if (myQueue.Count <= 10) {
                myQueue.Enqueue(userInput);
            }
            // Put error message if queue count exceeds 10
            else {
                Console.WriteLine("Max queue count has been exceeded");
                break;
            }
        }
        // Print out your queue dequeing it into a variable first
        while (myQueue.Count > 0) {
            Console.WriteLine(myQueue.Dequeue());
        }
    }
}
