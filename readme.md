## Building Arrays
Similar to defining a variable for one piece of data, when we define a variable to hold an array we also have to specify the type:

```
// These arrays store ints, strings, and doubles, respectively
int[] x; 
string[] s; 
double[] d; 

```

To declare a variable that holds an array, we first write the type of data that will be stored in an array, then add the square brackets `[]` to signify that it is holding an array (rather than a single value), followed by the name of the array.

Like a variable, we can define and initialize an array at the same time, by specifying the values we want to store in it:

`int[] plantHeights = { 3, 4, 6 };`

You may also see arrays defined and initialized using a new keyword:
`int[] plantHeights = new int[] { 3, 4, 6 };`

The new keyword signifies that we are instantiating a new array from the array class

In fact, if you decide to define an array and then initialize it later (rather in one line like above) you must use the new keyword:

```
// Initial declaration
int[] plantHeights;
 
// This works
plantHeights = new int[] { 3, 4, 6 };   
 
// This will cause an error
// plantHeights = { 3, 4, 6 }; 
```
---
## Array Length
We often want to know how many items an array contains. We can do this with the .Length property.

```
int[] plantHeights = { 3, 4, 6 };
 
// arrayLength will be 3
int arrayLength = plantHeights.Length 
```
---
## Accessing Array Items
To access a value from a list, we write out the name of the array, followed by brackets [] and within the brackets, the index number of that value that we want:

```
int[] plantHeights = {3, 4, 6};
 
// plantTwoHeight will be 4
int plantTwoHeight = plantHeight[1];
```
 ---

 ## Editing Arrays
 For example, we can initialize an array that has a length of three without specifying what those values are, then later go back and edit the array to include a new value. This is useful if we know how many things we’re expecting, but we don’t know their specific values yet:

 ```
 // plantHeights will be equal to [0, 0, 0]
int[] plantHeights = new int[3]; 
 
// plantHeights will now be [0, 0, 8]
plantHeights[2] = 8; 
 ```

 When we create the array with a known length but no known values, the array stores a default type value [(0 for int, null for string)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values). We then edit the array and swap out one of the default values with a new, specific value. In this case, we’re saying that at index 2 we want to swap the default value 0 for 8.

We can also edit the values of pre-existing arrays. Again, we can’t add to the length of an existing array, but we can swap out values:

```
int[] plantHeights = { 3, 4, 6 };
 
// plantHeights will be [3, 5, 6]
plantHeights[1] = 5; 
```
---
## [Built-In Methods](https://docs.microsoft.com/en-us/dotnet/api/system.array?view=net-6.0)

1. [SORT](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-6.0)

The built-in method `Array.Sort()` , as its name suggests, sorts an array. This method is a quick way to further organize array data into a logical sequence:

```
int[] plantHeights = { 3, 6, 4, 1 };
 
// plantHeights will be { 1, 3, 4, 6 }
Array.Sort(plantHeights); 
```

`Sort()` takes an array as a parameter and edits the array so its values are sorted. If it is an array of integer values, it will sort them into ascending values (lowest to highest). If it’s an array of string values, they would be sorted alphabetically.

2. [INDEX OF](https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-6.0)
The Array method `Array.IndexOf()`takes a value and returns its index. `IndexOf()` works best when you have a specific value and need to know where it’s located in the array (or if it even exists!). 

```
int[] plantHeights = { 3, 6, 4, 1, 6, 8 };
 
 // returns 1
Array.IndexOf(plantHeights, 6);
```

`IndexOf()` typically takes two parameters: the first is the array and the second is the value whose index we’re locating. `IndexOf() `also has several overloads that allow you to search for a specific range of the array. If the value appears more than once in an array, it returns only the first occurrence within the specified range. If it cannot find the value, it returns the lower bound of the array, minus 1 (since most arrays start at 0, it’s usually -1).

3. [FIND](https://docs.microsoft.com/en-us/dotnet/api/system.array.find?view=net-6.0)
The Array method `Array.Find()` searches a one-dimensional array for a specific value or set of values that match a certain condition and returns the first occurrence in the array.
```
int[] plantHeights = { 3, 6, 4, 1, 6, 8 };
 
// Find the first occurence of a plant height that is greater than 5 inches
int firstHeight = Array.Find(plantHeights, height => height > 5);
```

`Find()` takes two parameters: the first is the array and the second is a predicate that defines what we’re looking for. A predicate is a method that takes one input and outputs a boolean. Unlike `IndexOf()`, `Find()` returns the actual values that match the condition, instead of their index.

4. `Array.Copy()` [(documentation)](https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-6.0) copies a range of elements from one array to a second array. It takes three parameters: the name of the array to be copied, the new array, and the length of the array elements.

```
string[] players = { "Emily", "Kyle", "Todd", "Rachel", "Grayson" };
 
// This creates a new array with default values
string[] playersCopy = new string[5];
 
// This will populate the playersCopy array with { "Grayson", "Rachel", "Todd", "Kyle", "Emily" }
Array.Copy(players, playersCopy, 5);
```

5. `Array.Reverse() `[(documentation)](https://docs.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-6.0) will switch the order of elements in an entire array. It can also reverse them in a portion of an array, if the overload is used:
```
string[] players = { "Emily", "Kyle", "Todd", "Rachel", "Grayson" };
 
// This will return { "Grayson", "Rachel", "Todd", "Kyle", "Emily" }
Array.Reverse(players);

```

6. `Array.Clear() ` [(documentation)](https://docs.microsoft.com/en-us/dotnet/api/system.array.clear?view=net-6.0) sets a range of elements in an array to the default value. It takes three parameters: the name of the array, the starting index of the range to clear, and the number of elements to clear.

To clear an entire array, set the index to 0 (if it is zero-indexed) and then pass in the length of the array for the third parameter.

```
string[] players = { "Emily", "Kyle", "Todd", "Rachel", "Grayson" };
 
// This will return { null, null, null, null, null }
Array.Clear(players, 0, players.Length);
```
---
# Loops
## While Loop

The `while loop `looks very similar to an `if` statement. Just like an `if` statement, it executes the code inside of it `if` the condition, a statement that evaluates to a boolean value, is true.

a `while loop` will continue to execute the code inside of it, over and over again, while the condition is true. The computer is constantly checking to see if the condition is satisfied. For this reason, `while loops `are useful when you know at what point a program should stop, rather than the number of times it should repeat.


In your video game, you want the player to rise up in the air as long as the user is pressing the spacebar:

```
while (spacebar == "down") 
{
 RiseUp();
}

```

It will exit the while loop once the user releases the spacebar and then the rest of the program will continue.

---
## Do...While Loop
Similar to the `while loop`, a `do...while `loop will continue running until a stopping condition is met. One key difference is that no matter what, a `do...while loop `will always run once.


Instead of checking the condition before the code block executes, the program in the block runs once and then checks the conditional statement. It will either stop or continue to execute until the condition is no longer true. `do...while loops` are good for when a program should execute at least once and then depending on the circumstances, continue to execute or stop.


In your video game, you want to show the start screen for at least one frame. If the user does not hit next, you want the start screen to continue to appear until they do so.

```
bool startGame = false;
 
do
{
  ShowStartScreen();
} while (!startGame);
```
In this example, we initialize a Boolean value `startGame` to the state `false`. The program runs once, showing the start screen for one frame, then checks to see if the player has started the game. If the player has yet to start the game, it will call `ShowStartScreen()` again and will then continue to show the start screen until the player presses start.

---
## For Loop

The` for loop` tells the computer how many times to repeat the instructions using the `for` keyword and three expressions inside of parentheses. Each of these expressions use what’s known as an `iterator` variable, which is a variable that keeps track of how many times the program goes through the loop.

These expressions are:

1. Initialization: where the loop begins
2. Stopping condition: the condition that the iterator variable is evaluated against
3. Iteration statement: used to update the iterator variable on each loop

The `for loop` is good to use when you know the number of times you’d like to perform a task before you begin, like printing three copies of a document or inserting eight rows into a table.

```
for (int i = 0; i < 10; i++)
{
  DisplayFlag();
}
```
---
## For Each Loop
