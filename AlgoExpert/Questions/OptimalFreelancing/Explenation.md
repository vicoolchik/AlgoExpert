# AlgoExpert - Optimal Freelancing Solution

This code provides a solution to the "Optimal Freelancing" problem, where the task is to maximize the total payment a freelancer can earn by selecting jobs with deadlines and payments, ensuring that no more than one job is done per day.

## `OptimalFreelancing`

### Description
The `OptimalFreelancing` method aims to maximize the freelancer's earnings by selecting jobs that offer the highest payment and fitting them within their respective deadlines. The method first sorts the jobs by payment in descending order and then assigns the highest-paying jobs to the latest possible slots before their deadlines.

### Time and Space Complexity
- **Time Complexity:** O(n log n) - The time complexity is dominated by the sorting step, where `n` is the number of jobs.
- **Space Complexity:** O(n) - The method uses an additional array (`slots`) to track the availability of days, proportional to the maximum deadline.

### How It Works
1. **Sort Jobs by Payment:** The method sorts the jobs in descending order based on the payment amount. This ensures that the highest-paying jobs are considered first.

2. **Initialize Slots:** An array `slots` is initialized with a size equal to the maximum deadline, which represents the available days for completing jobs.

3. **Assign Jobs to Slots:**
   - For each job, the method checks the latest possible day (up to the job's deadline) to see if it is available (i.e., the slot is not already taken).
   - If an available slot is found, the job is assigned to that day, and the payment is added to the `totalPayment`.
   - This process ensures that high-paying jobs are prioritized and scheduled as late as possible to maximize the chances of fitting other jobs.

4. **Return Result:** After all jobs have been considered, the method returns the `totalPayment`, representing the maximum earnings the freelancer can achieve.

### Example Walkthrough

Given the following jobs:
- **Job 1:** Deadline = 3, Payment = 100
- **Job 2:** Deadline = 5, Payment = 150
- **Job 3:** Deadline = 2, Payment = 200

**Step 1:** Sort the jobs by payment:
- Sorted Jobs: 
  - Job 3: Deadline = 2, Payment = 200
  - Job 2: Deadline = 5, Payment = 150
  - Job 1: Deadline = 3, Payment = 100

**Step 2:** Initialize Slots:
- Slots: `[0, 0, 0, 0, 0, 0, 0]`

**Step 3:** Assign Jobs to Slots:
- Assign Job 3 to the latest available slot before day 2: 
  - Slots: `[0, 200, 0, 0, 0, 0, 0]`
  - Total Payment: `200`
  
- Assign Job 2 to the latest available slot before day 5: 
  - Slots: `[0, 200, 0, 0, 150, 0, 0]`
  - Total Payment: `350`
  
- Assign Job 1 to the latest available slot before day 3: 
  - Slots: `[0, 200, 0, 100, 150, 0, 0]`
  - Total Payment: `450`

**Step 4:** Return Result:
- The method returns `450`, which is the maximum total payment achievable.

### Pros
- **Efficiency:** The method efficiently maximizes earnings with a time complexity of O(n log n), making it suitable for large datasets.
- **Practical Application:** The algorithm is straightforward and mimics real-world scheduling where prioritization based on reward (payment) is crucial.

### Cons
- **Fixed Deadline Array:** The method assumes a fixed maximum deadline (in this case, `7`). If the number of days available for work changes, the `maxDeadline` variable needs to be adjusted accordingly.

## Conclusion

The `OptimalFreelancing` method provides an effective solution for maximizing earnings by optimally scheduling jobs with deadlines and payments. By sorting the jobs by payment and filling the latest possible slots first, the method ensures that the most valuable jobs are completed, leading to the highest possible total payment.

This approach is both efficient and easy to understand, making it a reliable choice for scenarios where job scheduling and maximization of rewards are key objectives.
