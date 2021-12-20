CREATE PROCEDURE dbo.spTournaments_Insert
	@TournamentName nvarchar(200),
	@EntryFee money,
	@Id int = 0 output
AS
BEGIN
	insert into dbo.Tournaments ( TournamentName , EntryFee , Active)
	values ( @TournamentName , @EntryFee , 1);
END
