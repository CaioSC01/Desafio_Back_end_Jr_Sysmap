CREATE TRIGGER Envia_email
ON dbo.usuarios
AFTER INSERT
AS
BEGIN
    DECLARE @email NVARCHAR(255) = 'contato@sistemas.com.br';
    DECLARE @subject NVARCHAR(255) = 'Novo usu�rio cadastrado';
    DECLARE @body NVARCHAR(MAX) = 'Um novo usu�rio foi cadastrado na aplica��o.';

    EXEC msdb.dbo.envia_email
    @recipients = @email,
    @subject = @subject,
    @body = @body;
END;