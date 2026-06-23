BEGIN TRANSACTION;

PRINT 'Outer Transaction Started';

BEGIN TRANSACTION;

PRINT 'Inner Transaction Started';

COMMIT TRANSACTION;

PRINT 'Inner Transaction Committed';

COMMIT TRANSACTION;

PRINT 'Outer Transaction Committed';
