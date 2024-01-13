CREATE PROCEDURE USP_INSERT_USUARIO
(
	@Nombres NVARCHAR(50),
	@Apellidos NVARCHAR(50),
	@Edad INT
)
AS
BEGIN

	INSERT INTO Usuario
	VALUES (@Nombres, @Apellidos, @Edad)

END