# Output

## Customer Order Count using CTE

The Common Table Expression (CTE) was used to count the total number of orders placed by each customer. The query then filtered customers who placed more than **3 orders**.

### Screenshot

![Exercise 5 Output](commontable.png)

---

## Result

| CustomerID | CustomerName | OrderCount |
|-----------:|--------------|-----------:|
| 1 | John | 4 |

---

## Observation

- A Common Table Expression (CTE) simplified the aggregation query.
- The CTE calculated the total number of orders for each customer.
- The final query returned only customers with more than **3 orders**.
- Customer **John** placed **4 orders**, satisfying the condition.

---

## Conclusion

This exercise demonstrates how Common Table Expressions (CTEs) improve query readability and simplify complex SQL operations. By separating the aggregation logic from the main query, the SQL becomes easier to understand and maintain.
