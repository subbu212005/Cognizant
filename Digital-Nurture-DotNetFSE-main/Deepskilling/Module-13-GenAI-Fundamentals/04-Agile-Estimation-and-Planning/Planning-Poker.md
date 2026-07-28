# Planning Poker: Collaborative Estimation

Planning Poker (also called Scrum Poker) is a consensus-based, gamified technique for estimating the relative size of user stories. It prevents anchoring bias and ensures all developer voices are heard.

---

## Steps of a Planning Poker Session

Here is how a standard Planning Poker session is conducted, whether co-located or remote:

```
[ PO Reads Story ] ---> [ Developers Discuss ] ---> [ Play Cards Simultaneously ]
                                                            |
[ Resolve Disagreement ] <--- [ Outliers Explain ] <--------+ (No consensus)
       |
       v
[ Save Estimate ] (Consensus achieved!)
```

### 1. Step 1: Read the Story
The Product Owner reads a user story from the backlog, explains the business requirements, and reads the Acceptance Criteria.

### 2. Step 2: Clarification & Discussion
The Developers ask questions, clarify technical constraints, discuss dependencies, and identify potential risks. The PO answers questions but does not participate in the estimation itself.

### 3. Step 3: Select and Play Cards
Each developer selects a card representing their estimate from their deck (Fibonacci: 1, 2, 3, 5, 8, 13, 20).
* **Crucial Rule**: Cards are kept secret until everyone has chosen. This avoids **anchoring bias** (where a junior developer simply copies the estimate of the tech lead).
* On a count of three, all developers reveal their cards simultaneously.

### 4. Step 4: Discuss and Resolve Disagreements
If all cards are identical or adjacent (e.g., all 3s and 5s), the team quickly reaches consensus (usually taking the higher number to be safe).
* If there is wide disagreement (e.g., estimates range from `2` to `13`):
  * **The lowest estimator** explains why they think the story is simple (e.g., *"We already have a helper utility that does this in one line"*).
  * **The highest estimator** explains why they think it is complex/risky (e.g., *"This requires database schema changes and we'll need to write a migration script"*).
  * *Crucial*: This discussion often reveals hidden complexity or simple solutions that other team members were unaware of.

### 5. Step 5: Re-Vote
After the discussion, the team re-votes. The process repeats until a consensus is reached (usually taking no more than two or three rounds).

---

## Special Cards

Most Planning Poker decks include a few non-numeric cards:

* **Coffee Cup**: *"I'm exhausted and need a break."*
* **Question Mark**: *"I have absolutely no idea what this story is asking. We need more refinement or a spike first."*
* **Infinity**: *"This story is too massive to estimate. It must be broken down into smaller stories (epics)."*

> [!TIP]
> **Avoid the Average**: Do not simply average the scores (e.g., if one person votes 2 and another votes 8, don't write down 5). The value of Planning Poker is in the **conversation** and reaching consensus, not doing math. Averaging masks the underlying technical disagreement.
