if Object_ID('dbo.usp_Qtde_Email','P') Is Not Null Drop Procedure dbo.usp_Qtde_Email
Go
Create Procedure usp_Qtde_Email

As
 declare @qtde int

 Select @qtde = Count(*) 
 from dbo.Usuarios as US
 Where DATEDIFF(day, US.DT_Criacao,GETDATE()) <= 92

  DECLARE @email NVARCHAR(255) = 'contato@sistemas.com.br';
    DECLARE @subject NVARCHAR(255) = 'Usuários Cadastrados'
    DECLARE @body NVARCHAR(MAX) = 'Qtde Usuarios Ultimos 92 dias:' + str(@qtde);

    EXEC msdb.dbo.envia_email
    @recipients = @email,
    @subject = @subject,
    @body = @body;


 --exec dbo.usp_Qtde_Email
 