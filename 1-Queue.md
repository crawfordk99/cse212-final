# Queues

_You're at a drive through with 2 different lanes. You order but the other person ordered first. They also get to the window before you. This makes them first on the queue (disregarding size of order which might make the workers decide to delay your order, and take care of the other ones first). A queue works similar to taking care of drive through orders._

## What is Queueing?

_A queue is pretty much a waiting list. It's a way to keep track of all the tasks you need to do, and prioritize the tasks that came up first. Our computers do this naturally behind the scenes whenever we make multiple requests at the same time (like having multiple web browsers open). In C# you can create a queue instance using Queue myQueue = new Queue(). Then add to the queue by using the dot operator and enqueue(value). _ 

```csharp
# Also can use var instead of Queue on the left hand side of the declaration
Queue<String> myQueue = new Queue<String>();
taskToDo1 = "Do Something";
taskToDo2 = "After this";
myQueue.Enqueue(taskToDo1);
myQueue.Enqueue(taskToDo2);
```

## First in First Out

_The data structure principle behind queues is FIFO (First in First Out). This means that whatever you put first on the queue (First In), will pop off the queue first (First Out). To pop off the queue you can use dequeue. 

```csharp
// Assuming earlier example, should print out Do Something
Console.WriteLine(myQueue.Dequeue()); 

// Then After This
Console.WriteLine(myQueue.Dequeue());
```

## Real Life Uses
_It's already been mentioned, but queues are really useful for web servers that have to handle multiple requests from multiple people at the same time. It's a great way to keep track of tasks, and helps give structure to the priority of task-handling (hence why it's a data structure). Customer Service lines, and phone answering systems are also great examples of real life use of the principle of queues. While C# has a built-in queue library (basically a pre-made queue function you can use to enqueue/dequeue from), you can apply the principle using lists as well._

```csharp
int request1 = 1
int request2 = 2
int request3 = 3

myQueue.Enqueue(request1);
myQueue.Enqueue(request2);
myQueue.Enqueue(request3);

// 1, then 2
String string1 = myQueue.Dequeue(); 
String string2 = myQueue.Dequeue();

int request4 = 4;
myQueue.Enqueue(request4);

// Should be 3, then 4
String string3 = myQueue.Dequeue();
String string4 = myQueue.Dequeue();
```
__Using Lists to Queue__

```csharp
new List<string> myQueue = new List<string>();

int request1 = 1
int request2 = 2
int request3 = 3

myQueue.Add(request1);
myQueue.Add(request2);
myQueue.Add(request3);

// 1, then 2
String string1 = myQueue[0];
myQueue.RemoveAt(0);
String string2 = myQueue[0];

int request4 = 4;
myQueue.Add(request4);
// Should be 3, then 4
String string3 = myQueue[0];
myQueue.RemoveAt(0);
String string4 = myQueue[0];
myQueue.RemoveAt(0);
```
## Efficiency
_The main queue functions of the built-in queue library in C# all have O(1) efficiency. Implementing queues using lists can decrease the efficiency if adding/removing from the front of the list._

- enqueue
- dequeue
- size (.Count)
- empty (if myQueue.Count == 0)

## Example Problem : Dishes to Wash
_Here's a simple example of keeping track of dishes to wash_

__Problems to Consider__

- How do we allow the user to add multiple dishes to the queue?
- How do we keep track of the dishes already washed?
- How do we display the results?
```csharp
Queue myQueue = new Queue();
Console.WriteLine("Add type of dish to queue, when finished press space.");
String userInput = "";
while(userInput != " "){
    userInput = Console.ReadLine();
    myQueue.Enqueue(userInput);
}
List<String> finishedDishes = new List<String>();
while (myQueue.Count != 0){
    finishedDishes.Add(myQueue.Dequeue());
}
foreach (String dish in finishedDishes){
    Console.WriteLine(dish);
}

```

## Problem to Solve : Using Queue to Keep Track of Assignments 

__Enter in your assignments for the week, and order them using a queue__

_Queues are good at keeping track of things. They are well organized and provide structure to your tasks. This problem is simply entering in your assignments and adding them to the queue, and then printing out your queue order of tasks. Give a limit of 10 to the size of your queue as well to help prevent your assignments from feeling overwhelming..._

```csharp
Enter in your assignments for the week, press space when done 
CSE212 Final project
Read Ivan Ilych

Queue - CSE212 Final Project
```
Remember. 

- Enqueue adds to the queue
- Dequeue removes the first value from the queue (FIFO)
- Count gives the size of the queue

__Test Cases__

- Enter 1 assignment to simply make sure you are enqueing and dequeing right to print out your queue list
- Enter 5 to make sure it's ordering them right
- Enter 11 to make sure an error message is given when you try to add more than 10.


[Solution](/queue-problem-solution)


[Back to Welcome Page](/0-welcome.md)