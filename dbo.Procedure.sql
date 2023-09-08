CREATE PROCEDURE spLogin
	@usuario varchar(20),
	@pass varchar(20)
AS
	SELECT top 1 COUNT(*) FROM usuarios
	WHERE usuarios.usuario = @usuario and usuarios.pass = @pass
RETURN 0
