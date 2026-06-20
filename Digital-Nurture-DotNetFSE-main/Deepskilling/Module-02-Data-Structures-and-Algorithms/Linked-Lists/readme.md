# Linked Lists

## Introduction

A Linked List is a dynamic linear data structure where elements are stored in nodes. Each node contains data and references to other nodes.

Unlike arrays, linked lists do not require contiguous memory allocation.

## Types of Linked Lists

### 1. Singly Linked List

Each node contains:

* Data
* Pointer to the next node

Example:

```text
10 → 20 → 30 → NULL
```

### 2. Circular Singly Linked List

The last node points back to the first node.

Example:

```text
10 → 20 → 30
↑         ↓
└─────────┘
```

### 3. Doubly Linked List

Each node contains:

* Data
* Previous pointer
* Next pointer

Example:

```text
NULL ← 10 ⇄ 20 ⇄ 30 → NULL
```

### 4. Circular Doubly Linked List

The first and last nodes are connected in both directions.

Example:

```text
10 ⇄ 20 ⇄ 30
↑           ↓
└───────────┘
```

## Operations on Linked Lists

### Traversal

Visiting each node exactly once.

### Searching

Finding a node containing a specific value.

### Insertion

Adding a new node:

* At Beginning
* At End
* At Specific Position

### Deletion

Removing a node:

* From Beginning
* From End
* From Specific Position

## Time Complexity

| Operation              | Time Complexity |
| ---------------------- | --------------- |
| Traversal              | O(n)            |
| Search                 | O(n)            |
| Insertion at Beginning | O(1)            |
| Insertion at End       | O(n)            |
| Deletion               | O(n)            |

## Program Output

```text
Linked List Elements:
10
20
30
```

## Observation

Linked Lists provide dynamic memory allocation and efficient insertion operations. Traversal and searching require visiting nodes sequentially, resulting in O(n) time complexity.

## Learning Outcome

After completing this topic, I understood different types of linked lists, their operations, and the time complexity associated with insertion, deletion, searching, and traversal.

## Conclusion

Linked Lists are useful when frequent insertion and deletion operations are required. They provide flexibility and dynamic memory management compared to arrays.

