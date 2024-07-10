# Sets

_Sets are a foundational mathematical concept that is very integral to software engineering, even if it's not directly used often. Think of the allowable password characters, keys in dictionaries, lists without repeatable values, and if you have any experience with SQL, think of SELECT DISTINCT queries._

```csharp
HashSet<int> set1 = new HashSet<int>(){0, 1, 5, 7};
```

## What are Sets?
_Unlike lists/arrays, stacks, and queues, sets don't allow for duplicates. In terms of coding, each value in the set is given a unique memory spot, not necessarily from left to right like lists/arrays (index 0, 1, 2, 3, etc.). Because of this, they also don't care about order. Therefore, 2 sets like {1, 2, 3} and {3, 2, 1} would be equal and count as 1 set._

```csharp
HashSet<int> set1 = new HashSet<int>(){0, 1, 2};
HashSet<int> set2 = new HashSet<int>(){2, 1, 0};

// Should just be {0, 1, 2}
// Intersect combines values that both sets share
set3 = set1.Intersect(set2).ToHashset(); 

// {0, 1, 2, 5}
set4 = set1.Add(5);

// {0, 1, 2, 5}
// Union combines all the unique values of both sets
set5 = set1.Union(set4).ToHashSet();
```

## Hashing
_In small set just for numbers, numbers can just be placed in the index that equals their value like 7 is in index 7, and 10 is in index 10, and it doesn't take up too much memory. However, when you have bigger sets, and also include words/characters, the memory space can grow out of control (basically, sets have to reserve space based on the highest value, not how many items are in it). Thankfully, C# and other languages have built-in hash functions to deal with this problem when creating sets. Based on the data, it can create a smaller integer (GetHashCode) value for each item in the set. 

```csharp
# Use object data type to allow any data type to be added
HashSet<object> set1 = new HashSet<object>(){1, "Hey", 171959, 5};
foreach (object item in set1) {
    Console.WriteLine(item.GetHashCode());
}
```

## Conflicts
_Sometimes, the hash values can overlap. In this case we have 2 options. We can keep moving until we find an index value that is open, but that runs the risk of more overlap later when more data is added to the set. Or we can make list inside of the set in that index spot when there is more than 1 value with the same hash code. That's called chaining. Either way, it can slow down the set's performance, and at that point, you have to question whether a set is the right data structure to use for your data._

## Real Life Uses
_Sets are very useful when it comes to finding unique results in your data. Like lets say for some reason you're looking for unique birthdays of your coworkers. Creating a set of everyone's birthdays would make this a lot easier than sifting through a list. SQL is one of the most popular database languages, and most of it's search functions work like set functions (and you can do similar things like the birthday example). It may not be worded a set, but the data structure of sets is a key foundation to many resources we have today of sifting through data much quicker than lists/arrays._

## Efficiency
_Again, sets can be a lot more efficient thanks to the unique values, and the restrictions surrounding duplicates. All you need is the hash value, and you can find a number in the set in O(1) time, as long as there is no conflicts. The main functions are .Add, .Remove, .Contains, and .Count()._


## Example Problem : Showing Unique Basketball Stat Lines

_Here's an example of using sets to represent stat lines, and then combining them together using set union to show only the unique statlines._

__Problems to Consider__
- What data type should we make the set to represent stat lines?
- How do we join 2 sets?

```csharp
HashSet<string> set 1 = new HashSet<string>(){"23-10-9", "31-7-9", "41-5-5"};
HashSet<string> set 2 = new HashSet<string>(){"30-3-7", "27-8-6" "41-5-5"};

set3 = set1.Union(set2).ToHashSet; //{"23-10-9", "31-7-9", "41-5-5", "30-3-7", "27-8-6"}, remember order doesn't matter in sets
```

## Problem to Solve : Student Attendance
__Given a list of names of students who attended, create a HashSet__

_Your sub made a list of the students who attended, but he double counted some. To make sure no one is double counted, create a set from the list by iterating through the list._ 

- ["Jake Adams", "Mark Jones", "Shalia Foster", "Luis Gonzalez", "Inter Miami", "Jake Adams", "Nicole Adams", "Pixie Dust", "Shalia Foster", "Insure Does", "Luka Jokic"]

_Ensure that your program accounts for duplicates before adding to the HashSet. Make a separate set of the duplicates to ensure you actually understood, and implemented the concept._

```csharp
{"Jake Adams", "Mark Jones", "Shalia Foster", "Luis Gonzalez", "Inter Miami", "Nicole Adams", "Pixie Dust", "Insure Does", "Luka Jokic"}

{"Jake Adams", "Shalia Foster"}
```

- Remember that you can use .Contains to check if the set already has a value...

[Problem Solution](/set-problem-solution/)


[Back to Welcome Page](/0-welcome.md)