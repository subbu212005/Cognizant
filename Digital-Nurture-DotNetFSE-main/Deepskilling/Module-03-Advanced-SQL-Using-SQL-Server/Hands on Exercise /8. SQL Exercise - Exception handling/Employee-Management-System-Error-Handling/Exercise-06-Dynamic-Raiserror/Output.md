### Expected Output for Exercise-06-Dynamic-Raiserror

When executing the test cases:

#### **Test 1: Transfer non-existent employee ID (`999`)**
`EXEC sp_TransferEmployee 999, 1;`

**Result Set:**
| Status | ErrorDetails |
| :--- | :--- |
| Transfer Failed | Employee ID 999 was not found in the database. Transfer aborted. |

---

#### **Test 2: Transfer existing employee to non-existent department ID (`888`)**
`EXEC sp_TransferEmployee 101, 888;`

**Result Set:**
| Status | ErrorDetails |
| :--- | :--- |
| Transfer Failed | Department ID 888 does not exist. Cannot transfer Employee ID 101. |

---

#### **Logged Entry in AuditLog Table:**

| Action | ErrorMessage |
| :--- | :--- |
| TRANSFER FAILED | Employee ID 999 was not found in the database. Transfer aborted. |
| TRANSFER FAILED | Department ID 888 does not exist. Cannot transfer Employee ID 101. |
