BEGIN TRANSACTION;

UPDATE BankAccounts
SET Balance=Balance-1000
WHERE AccountID=101;

UPDATE BankAccounts
SET Balance=Balance+1000
WHERE AccountID=102;

COMMIT;
