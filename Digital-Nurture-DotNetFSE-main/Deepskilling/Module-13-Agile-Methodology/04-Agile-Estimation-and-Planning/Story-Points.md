# Story Points & Relative Sizing

Story Points are an arbitrary unit of measure used by agile teams to express an estimate of the overall **effort, complexity, and risk** required to fully implement a product backlog item.

---

## The Three Dimensions of Story Points

When estimating a user story in points, developers must consider three variables:

```
             Complexity  <-- How hard is it to build?
                 |
                 |
   Effort -------+----- Risk & Uncertainty  <-- What could go wrong?
(How much work?)
```

1. **Effort**: The volume of work. Writing 10 basic HTML pages takes more effort than writing 1 page, even if the code is simple.
2. **Complexity**: The difficulty of the task. Writing a complex multi-layered recommendation algorithm is highly complex, even if the final code is short.
3. **Risk & Uncertainty**: The unknown variables. Integrating a third-party payment gateway with poor documentation has high risk and uncertainty.

---

## The Modified Fibonacci Sequence

Agile teams typically use a modified Fibonacci sequence for estimation:
**1, 2, 3, 5, 8, 13, 20, 40, 100**

### Why Fibonacci?
As numbers get larger, our ability to distinguish between close values decreases (Weber's Law). 
* It is easy to feel the difference between a 1-pound weight and a 2-pound weight.
* It is impossible to feel the difference between a 50-pound weight and a 51-pound weight.
* In software estimation, it is a waste of time to debate whether a story is a 12 or a 13. By forcing the team to choose between **8, 13, or 20**, Scrum eliminates tedious debates and reflects the natural uncertainty that comes with larger tasks.

---

## Story Points vs. Hours: Why Decouple?

| Feature | Story Points | Hours |
| :--- | :--- | :--- |
| **Stability** | **Static**. A story stays 5 points regardless of who builds it. | **Dynamic**. Takes Senior 2 hrs, Junior 10 hrs. |
| **Emphasis** | Focuses on complexity and teamwork. | Focuses on time tracking and micromanagement. |
| **Discussion** | Promotes alignment on requirements and risks. | Promotes arguments about developer efficiency. |
| **Planning** | Tied to team speed (Velocity). | Tied to calendar math. |

### Common Trap: The Conversion Fallacy
A major anti-pattern is trying to convert points directly into hours (e.g., *"1 point = 8 hours"*). 
If you do this:
1. You lose the benefit of relative estimation.
2. Developers will inflate their estimates to protect themselves.
3. The team will return to estimating in hours under a different name.

> [!TIP]
> **T-Shirt Sizing**: If numeric points are too abstract for your team, start with T-shirt sizes: **XS, S, M, L, XL**. Once the team gets comfortable comparing sizes, map them to Fibonacci numbers (XS=1, S=2, M=5, L=8, XL=13) to calculate velocity.
