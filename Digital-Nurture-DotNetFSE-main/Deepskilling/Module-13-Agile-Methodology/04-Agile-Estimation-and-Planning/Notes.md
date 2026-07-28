# Notes: The Agile Planning Onion & Relative Estimation

Planning in Agile is not a single event. It is a continuous activity that happens at multiple horizons of the project lifecycle.

---

## The Agile Planning Onion

Agile planning happens at six distinct levels, often visualized as layers of an onion. The outer layers are long-term and broad, while the inner layers are short-term, detailed, and highly precise.

```
       [   Strategy   ]  <-- Exec Leadership (Years)
         [  Portfolio  ] <-- Product Board (Quarters/Years)
           [  Product  ] <-- Product Owner (Months)
             [ Release ] <-- PO & Team (Sprints/Months)
               [Sprint]  <-- Scrum Team (1-4 Weeks)
                [Daily]  <-- Developers (24 Hours)
```

1. **Strategy**: Executive leadership establishes the company's vision, long-term direction, and financial goals (Yearly).
2. **Portfolio**: Defining which products, initiatives, or lines of business will be funded to meet the strategy (Quarters).
3. **Product**: The Product Owner defines the roadmap, product vision, and long-term Product Goal (Months).
4. **Release**: Planning when increments of value will be shipped to customers (Sprints/Months).
5. **Sprint**: The Scrum Team plans the work they will deliver in the upcoming iteration to achieve the Sprint Goal (Weeks).
6. **Daily**: The Developers align their work, inspect blockers, and plan their next 24 hours to meet the Sprint Goal (Daily).

---

## Absolute vs. Relative Estimation

In traditional projects, teams try to estimate tasks in **absolute terms** (e.g., *"This task will take exactly 14 hours"*). This is notoriously inaccurate because:
* **Developer differences**: A senior engineer might write the code in 2 hours, whereas a junior developer might take 16 hours.
* **Hidden complexity**: We are bad at estimating time because we forget to factor in meetings, interruptions, code reviews, and debugging.
* **Law of Large Numbers**: Small errors in hour estimates compound quickly across a large project.

### Relative Estimation (The Agile Alternative)
Agile uses **relative estimation**. Instead of asking *"How long will this take?"*, we ask *"How big, complex, and risky is this compared to other things we have built?"*

* *The Analogy*: If I show you a small cup and a large bucket, you don't know exactly how many ounces of water they hold (absolute). But you do know immediately that the bucket is about 10 times larger than the cup (relative).
* If we assign the small cup a size of `1`, we can comfortably assign the bucket a size of `8` or `13`.

### Benefits of Relative Estimation
1. **Speed**: Relative estimates are much faster to produce than detailed hourly breakdowns.
2. **Accuracy**: Teams are statistically much more accurate at comparing sizes than estimating hours.
3. **Role-Independent**: A junior developer and a senior developer can agree that task A is "twice as big" as task B, even if it takes them different amounts of time to complete.
