# Heap Sort

## Introduction

Heap Sort is a comparison-based sorting algorithm that uses a Binary Heap data structure to sort elements efficiently.

It first builds a max heap and then repeatedly extracts the largest element.

## Working

1. Build a Max Heap.
2. Swap the root element with the last element.
3. Reduce heap size.
4. Heapify the root.
5. Repeat until sorted.

## Time Complexity

| Case         | Complexity |
| ------------ | ---------- |
| Best Case    | O(n log n) |
| Average Case | O(n log n) |
| Worst Case   | O(n log n) |

## Advantages

* Efficient performance
* In-place sorting
* Guaranteed O(n log n)

## Learning Outcome

Learned how Heap Sort uses a Binary Heap structure to achieve efficient sorting performance.
