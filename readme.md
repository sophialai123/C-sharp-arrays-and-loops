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




