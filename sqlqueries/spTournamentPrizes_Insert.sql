
CREATE PROCEDURE dbo.spTournamentPrizes_Insert
	-- Add the parameters for the stored procedure here
	@TournamentId int,
	@PrizeId int,
	@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.TournamentPrizes (TournamentId, PrizeId)
	values (@TournamentId, @PrizeId);

	select @id = SCOPE_IDENTITY();
END
GO
