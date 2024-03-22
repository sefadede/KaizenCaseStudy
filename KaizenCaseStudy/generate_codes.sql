CREATE PROCEDURE [dbo].[generate_codes]
AS
BEGIN
    DECLARE @Charset VARCHAR(20) = 'ACDEFGHKLMNPRTXYZ234579'
    DECLARE @CodeLength INT = 8
    DECLARE @Code VARCHAR(8) = ''
    DECLARE @Index INT = 1

    WHILE @Index <= @CodeLength
    BEGIN
        SET @Code = @Code + SUBSTRING(@Charset, CAST(RAND() * LEN(@Charset) + 1 AS INT), 1)
        SET @Index = @Index + 1
    END

    SELECT @Code AS GeneratedCode
END
GO