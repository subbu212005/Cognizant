# Sample User Stories: Bad vs. Good

To master the art of writing requirements in Agile, let's look at real-world examples of poorly written requirements contrasted with high-quality, sprint-ready user stories.

---

## E-Commerce Application Examples

### Example 1: The Technical Spec (Bad)
* **Title**: `Create Checkout Button backend API`
* **Description**:  
  We need a POST API endpoint at `/api/v1/checkout` that receives the user's cart ID, processes the payment in Stripe, and inserts a row into the database.
* **Why it's bad**: 
  * It focuses entirely on technical implementation rather than user value.
  * It is not negotiable.
  * It lacks business context (the "Why").

### Example 1: Sliced by Value (Good)
* **Title**: `Purchase cart items using Stripe credit card payment`
* **Description**:  
  **As a** registered customer with items in my shopping cart,  
  **I want to** pay for my items using my credit card via the Stripe payment form,  
  **So that** I can complete my purchase and have the items shipped to my address.
* **Acceptance Criteria**:
  * [ ] **Rule**: Credit card numbers must be validated on the client side (Luhn algorithm check).
  * [ ] **Rule**: The system must not store full credit card numbers in our database.
  * [ ] **Gherkin Scenario**:
    ```gherkin
    Scenario: Successful Purchase
      Given the customer is on the checkout page
       And has items totaling $50 in their cart
      When they enter valid credit card details
       And click the "Complete Order" button
      Then Stripe processes the transaction successfully
       And an order confirmation page is displayed with order ID
       And a confirmation email is sent to the customer
    ```

---

## Booking Application Examples

### Example 2: The Giant Epic (Bad)
* **Title**: `Search and Book Flights`
* **Description**:  
  The user should be able to search for flights, filter by price and airline, select departure and return times, enter passenger information, choose seats, and complete a booking.
* **Why it's bad**:
  * It is far too large to fit in a single sprint (violates the S in INVEST).
  * It contains too many nested requirements, making testing and estimation impossible.

### Example 2: Sliced into Sprints (Good)
This epic must be sliced into multiple small, independent user stories:

#### Story A: Search flights by destination and date
* **As a** traveler,  
  **I want to** search for flights by inputting a departure city, destination city, and departure date,  
  **So that** I can see what flights are available for my trip.
* **Acceptance Criteria**:
  * [ ] User must be prompted with autocomplete options for airport names.
  * [ ] The system must block users from choosing departure dates in the past.

#### Story B: Filter flight search results by price
* **As a** budget-conscious traveler,  
  **I want to** filter my flight search results by maximum price,  
  **So that** I can quickly find options that fit my budget.
* **Acceptance Criteria**:
  * [ ] The system must display a price range slider ranging from $0 to the maximum ticket price.
  * [ ] Filtering must update results instantly without reloading the page.
