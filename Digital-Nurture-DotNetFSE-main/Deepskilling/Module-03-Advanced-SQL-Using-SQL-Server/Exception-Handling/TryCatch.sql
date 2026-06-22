BEGIN TRY
    DECLARE @Marks INT=100;
    DECLARE @Students INT=0;

    SELECT @Marks / @Students AS AverageMarks;
END TRY

BEGIN CATCH
    SELECT
        ERROR_NUMBER() AS ErrorNumber,
        ERROR_MESSAGE() AS ErrorMessage,
        ERROR_LINE() AS ErrorLine;
END CATCH;
