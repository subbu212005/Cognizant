# Burndown & Burnup Charts: Tracking Sprint Progress

Agile teams use visual charts to track daily progress during a sprint and monitor long-term release milestones. The most common charts are the **Sprint Burndown Chart** and the **Release Burnup Chart**.

---

## The Sprint Burndown Chart

A Sprint Burndown Chart shows the amount of work remaining in the sprint backlog on a daily basis.

* **Y-Axis**: Total remaining effort (usually in **tasks hours** or **story points**).
* **X-Axis**: Days of the sprint (typically 10 working days).
* **Ideal Trend Line**: A straight diagonal line from the total estimated effort on Day 1 to zero on the final day of the sprint.
* **Actual Trend Line**: The team's actual daily progress as tasks are completed.

```
Points
  30 | \   [Ideal Line]
  25 |  \
  20 |   \__.__
  15 |         \___ [Actual Line]
  10 |             \
   5 |              \._
   0 +-------------------
     D1 D2 D3 D4 D5 D6 D7 D8 D9 D10 Days
```

---

## Reading Common Burndown Patterns

The shape of the actual trend line reveals team behaviors, blockages, or planning problems:

### 1. The Ideal Slide
* **Pattern**: The actual line closely hugs the ideal line, dropping steadily every day.
* **Meaning**: Tasks are small and independent, work is flowing smoothly, and developers are collaborating effectively.

### 2. The Late Drop (The Waterfall Sprint)
* **Pattern**: The line remains flat at 30 points until Day 8, then drops vertically to 0 on Day 10.
* **Meaning**: Developers are working in silos. Features are coding-complete but waiting for code reviews, testing, or PO approval until the very end. This represents high risk.

### 3. The Plateau (Flat Line)
* **Pattern**: The actual line drops initially, then stays flat for several days mid-sprint.
* **Meaning**: The team is blocked. There might be environment issues, waiting on design specs, or an unresolved dependency on another team.

### 4. The Mountain (Scope Creep)
* **Pattern**: The remaining effort line rises above the starting point during the sprint.
* **Meaning**: Scope creep. The Product Owner is adding new user stories mid-sprint, or the team discovered significant hidden complexity and added new tasks to the sprint backlog.

---

## Sprint Burndown vs. Release Burnup

While burndowns track daily sprint progress, burnup charts are better for long-term release tracking because they show scope changes clearly.

| Chart Type | Burndown | Burnup |
| :--- | :--- | :--- |
| **Focus** | Remaining work. | Completed work vs. Total scope. |
| **Visual Structure** | A single line moving downward. | Two lines: one moving upward (Completed), one flat/stepping upward (Scope). |
| **Best Used For** | Daily developer alignment during a sprint. | Product Owner release tracking and scope creep monitoring. |

```
Scope
 150 |============================ [Total Scope Line]
 120 |                     .----'
  90 |              .-----' [Completed Work Line]
  60 |        .----'
  30 | .-----'
   0 +--------------------------------------------
     S1      S2      S3      S4      S5    Sprints
```

> [!TIP]
> **Keep it updated daily!** A burndown chart is only useful if developers update their task statuses during the day or right after the Daily Scrum. If they wait until the end of the sprint, the chart is useless.
