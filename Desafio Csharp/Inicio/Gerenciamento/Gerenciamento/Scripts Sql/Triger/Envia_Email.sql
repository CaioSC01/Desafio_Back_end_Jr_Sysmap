CREATE TRIGGER Envia_email
ON dbo.usuarios
AFTER INSERT
AS
BEGIN
    DECLARE @email NVARCHAR(255) = 'contato@sistemas.com.br';
    DECLARE @subject NVARCHAR(255) = 'Novo usuário cadastrado';
    DECLARE @body NVARCHAR(MAX) = 'Um novo usuário foi cadastrado na aplicação.';

    EXEC msdb.dbo.envia_email
    @recipients = @email,
    @subject = @subject,
    @body = @body;
END;