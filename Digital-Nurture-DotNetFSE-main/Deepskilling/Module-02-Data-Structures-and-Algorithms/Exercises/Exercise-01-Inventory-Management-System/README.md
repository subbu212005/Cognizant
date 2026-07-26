# Exercise 1: Inventory Management System

## Aim

To develop an Inventory Management System using C# and the `Dictionary` collection for efficient storage and retrieval of product information.

---

## Scenario

You are developing an inventory management system for a warehouse. Efficient data storage and retrieval are crucial for managing a large number of products. The system should support adding, updating, deleting, and displaying product details.

---

## Objectives

- Understand the importance of Data Structures and Algorithms.
- Implement CRUD operations on inventory data.
- Use a suitable data structure for efficient performance.
- Analyze the time complexity of inventory operations.

---

## Data Structure Used

**Dictionary<int, Product>**

A Dictionary stores products using the Product ID as the key, providing fast lookup, insertion, update, and deletion.

---

## Classes

- Product
- InventoryManager
- Program

---

## Operations Implemented

- Add Product
- Update Product
- Delete Product
- Display Products

---

## Time Complexity

| Operation | Complexity |
|-----------|------------|
| Add | O(1) |
| Update | O(1) |
| Delete | O(1) |
| Search | O(1) |

---

## Expected Output

Refer to **Output.md**

---

## Conclusion

Using a Dictionary significantly improves inventory management performance compared to using arrays or lists for searching by Product ID.
