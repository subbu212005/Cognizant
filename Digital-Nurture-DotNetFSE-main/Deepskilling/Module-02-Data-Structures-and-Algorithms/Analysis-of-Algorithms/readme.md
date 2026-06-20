# Analysis of Algorithms

## Introduction

Analysis of Algorithms is the process of evaluating the performance of an algorithm in terms of execution time and memory usage.

It helps developers choose the most efficient solution for a problem.

## Why Data Structures and Algorithms?

Data Structures organize and store data efficiently.

Algorithms provide step-by-step instructions to solve problems.

### Benefits

* Faster execution
* Better memory utilization
* Improved scalability
* Efficient problem solving
* Better software performance

## Types of Data Structures

### Linear Data Structures

Elements are stored sequentially.

#### Examples

* Array
* Linked List
* Stack
* Queue

### Non-Linear Data Structures

Elements are stored hierarchically.

#### Examples

* Tree
* Graph
* Heap

## Time Complexity

Time Complexity measures how execution time grows as input size increases.

### Common Complexities

| Complexity | Description       |
| ---------- | ----------------- |
| O(1)       | Constant Time     |
| O(log n)   | Logarithmic Time  |
| O(n)       | Linear Time       |
| O(n log n) | Linearithmic Time |
| O(n²)      | Quadratic Time    |
| O(2ⁿ)      | Exponential Time  |

## Space Complexity

Space Complexity measures the amount of memory used by an algorithm during execution.

### Examples

* Variables
* Arrays
* Function Call Stack

## Asymptotic Notations

### Big O Notation

Represents the upper bound (Worst Case).

Example:

```text
O(n)
```

### Omega Notation (Ω)

Represents the lower bound (Best Case).

Example:

```text
Ω(n)
```

### Theta Notation (Θ)

Represents the exact growth rate.

Example:

```text
Θ(n)
```

## Analysis Types

### Best Case

Minimum execution time.

Example:

Searching an element found at the first position.

### Average Case

Expected execution time for normal inputs.

### Worst Case

Maximum execution time.

Example:

Searching an element located at the last position.

## Example Time Complexity

### Single Loop

```csharp
for(int i = 0; i < n; i++)
{
    Console.WriteLine(i);
}
```

Time Complexity: **O(n)**

## Learning Outcome

After completing this topic, I understood the importance of algorithm analysis, time complexity, space complexity, asymptotic notations, and how to evaluate the efficiency of algorithms.

## Conclusion

Analysis of Algorithms helps developers design efficient and scalable applications by selecting the most suitable data structures and algorithms for solving real-world problems.

