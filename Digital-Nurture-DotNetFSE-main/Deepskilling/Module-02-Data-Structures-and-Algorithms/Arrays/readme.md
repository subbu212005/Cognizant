# Arrays

## Introduction

An Array is a linear data structure used to store multiple elements of the same data type in contiguous memory locations.

Arrays provide fast access to elements using their index positions and are one of the most commonly used data structures in programming.

## Array Representation in Memory

Array elements are stored in consecutive memory locations.

Example:

```text
Index : 0   1   2   3   4
Value : 10  20  30  40  50
```

Memory Representation:

```text
Address   Value
1000      10
1004      20
1008      30
1012      40
1016      50
```

## Traversal in Arrays

Traversal means visiting each element of the array exactly once.

Example:

```csharp
int[] arr = {10, 20, 30, 40, 50};

foreach(int item in arr)
{
    Console.WriteLine(item);
}
```

## Searching in Arrays

Searching is the process of finding a specific element in an array.

### Linear Search

Linear Search checks each element one by one until the required element is found.

Example:

```csharp
int[] arr = {10, 20, 30, 40, 50};
int key = 30;
```

Time Complexity:

* Best Case: O(1)
* Average Case: O(n)
* Worst Case: O(n)

## Measuring Time Complexity

Time Complexity measures how the execution time of an algorithm grows as the input size increases.

### Common Operations

| Operation     | Time Complexity |
| ------------- | --------------- |
| Access        | O(1)            |
| Traversal     | O(n)            |
| Linear Search | O(n)            |
| Insertion     | O(n)            |
| Deletion      | O(n)            |

## When to Use Arrays

Arrays are suitable when:

* The number of elements is fixed.
* Fast access using indexes is required.
* Memory efficiency is important.
* Data elements are of the same type.

## Program Output

```text
Array Elements:
10
20
30
40
50
```

## Observation

Array traversal visits every element exactly once. Therefore, the traversal operation requires O(n) time complexity, where n is the number of elements in the array.

## Learning Outcome

After completing this topic, I understood array representation in memory, array traversal, searching techniques, time complexity analysis, and situations where arrays are the most suitable data structure.

## Conclusion

Arrays provide efficient storage and quick access to data using indexes. They are widely used in software development and serve as the foundation for many advanced data structures.

