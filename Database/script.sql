USE [master]
GO
/****** Object:  Database [Cinema]    Script Date: 03/02/2020 13:43:42 ******/
CREATE DATABASE [Cinema]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cinema', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Cinema_Primary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cinema_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Cinema_Primary.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Cinema] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cinema].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cinema] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cinema] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cinema] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cinema] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cinema] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cinema] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Cinema] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cinema] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cinema] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cinema] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cinema] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cinema] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cinema] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cinema] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cinema] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Cinema] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cinema] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cinema] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cinema] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cinema] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cinema] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cinema] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cinema] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Cinema] SET  MULTI_USER 
GO
ALTER DATABASE [Cinema] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cinema] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cinema] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cinema] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cinema] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Cinema] SET QUERY_STORE = OFF
GO
USE [Cinema]
GO
/****** Object:  Schema [Cinema]    Script Date: 03/02/2020 13:43:42 ******/
CREATE SCHEMA [Cinema]
GO
/****** Object:  Table [Cinema].[Admin]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cinema].[Admin](
	[UsernameAdmin] [varchar](30) NOT NULL,
	[Password] [varchar](32) NOT NULL,
	[Nome] [varchar](20) NOT NULL,
	[Cognome] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UsernameAdmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cinema].[Evento]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cinema].[Evento](
	[CodiceEvento] [int] IDENTITY(1,1) NOT NULL,
	[DataOra] [datetime] NOT NULL,
	[Codice_Film] [int] NOT NULL,
	[Codice_Sala] [int] NOT NULL,
	[Username_Admin] [varchar](30) NOT NULL,
	[Prezzo] [decimal](3, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodiceEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cinema].[Film]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cinema].[Film](
	[CodiceFilm] [int] IDENTITY(1,1) NOT NULL,
	[Titolo] [varchar](50) NOT NULL,
	[Anno] [int] NOT NULL,
	[Regia] [varchar](30) NOT NULL,
	[Durata] [int] NOT NULL,
	[Data_Uscita] [date] NOT NULL,
	[Genere] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodiceFilm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cinema].[Posto]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cinema].[Posto](
	[NumeroPosto] [int] NOT NULL,
	[Codice_Sala] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NumeroPosto] ASC,
	[Codice_Sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cinema].[Prenotazione]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cinema].[Prenotazione](
	[CodicePrenotazione] [int] IDENTITY(1,1) NOT NULL,
	[DataOra] [datetime] NOT NULL,
	[Username_UtenteFree] [varchar](30) NOT NULL,
	[Codice_Evento] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodicePrenotazione] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cinema].[Riserva]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cinema].[Riserva](
	[Numero_Posto] [int] NOT NULL,
	[Codice_Prenotazione] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Numero_Posto] ASC,
	[Codice_Prenotazione] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cinema].[Sala]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cinema].[Sala](
	[CodiceSala] [int] IDENTITY(1,1) NOT NULL,
	[Capienza] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodiceSala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cinema].[UtenteFree]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cinema].[UtenteFree](
	[UsernameUtenteFree] [varchar](30) NOT NULL,
	[Password] [varchar](32) NOT NULL,
	[Nome] [varchar](20) NOT NULL,
	[Cognome] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UsernameUtenteFree] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [Cinema].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Codice_Film_Evento] FOREIGN KEY([Codice_Film])
REFERENCES [Cinema].[Film] ([CodiceFilm])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Cinema].[Evento] CHECK CONSTRAINT [FK_Codice_Film_Evento]
GO
ALTER TABLE [Cinema].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Codice_Sala_Evento] FOREIGN KEY([Codice_Sala])
REFERENCES [Cinema].[Sala] ([CodiceSala])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Cinema].[Evento] CHECK CONSTRAINT [FK_Codice_Sala_Evento]
GO
ALTER TABLE [Cinema].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Username_Admin_Evento] FOREIGN KEY([Username_Admin])
REFERENCES [Cinema].[Admin] ([UsernameAdmin])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Cinema].[Evento] CHECK CONSTRAINT [FK_Username_Admin_Evento]
GO
ALTER TABLE [Cinema].[Posto]  WITH CHECK ADD  CONSTRAINT [FK_Codice_Sala_Posto] FOREIGN KEY([Codice_Sala])
REFERENCES [Cinema].[Sala] ([CodiceSala])
GO
ALTER TABLE [Cinema].[Posto] CHECK CONSTRAINT [FK_Codice_Sala_Posto]
GO
ALTER TABLE [Cinema].[Prenotazione]  WITH CHECK ADD  CONSTRAINT [FK_Utente_Free_Prenotazione] FOREIGN KEY([Username_UtenteFree])
REFERENCES [Cinema].[UtenteFree] ([UsernameUtenteFree])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Cinema].[Prenotazione] CHECK CONSTRAINT [FK_Utente_Free_Prenotazione]
GO
ALTER TABLE [Cinema].[Riserva]  WITH CHECK ADD  CONSTRAINT [FK_Codice_Prenotazione_Riserva] FOREIGN KEY([Codice_Prenotazione])
REFERENCES [Cinema].[Prenotazione] ([CodicePrenotazione])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Cinema].[Riserva] CHECK CONSTRAINT [FK_Codice_Prenotazione_Riserva]
GO
/****** Object:  StoredProcedure [Cinema].[AddNewEvento]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[AddNewEvento]
      @DataOra datetime,
      @Codice_Film int,
	  @Codice_Sala int,
      @Username_Admin varchar(30),
	  @Prezzo decimal,
	  @CodiceEvento int output
AS
BEGIN
      SET NOCOUNT ON;
      INSERT INTO  Cinema.Evento(DataOra, Codice_Film, Codice_Sala, Username_Admin, Prezzo)
      VALUES (@DataOra, @Codice_Film, @Codice_Sala, @Username_Admin, @Prezzo)
      SET @CodiceEvento=SCOPE_IDENTITY()
      RETURN  @CodiceEvento
END
GO
/****** Object:  StoredProcedure [Cinema].[AddNewFilm]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[AddNewFilm]
      @Titolo varchar(50),
      @Anno int,
      @Regia varchar(30),
	  @Durata int,
      @Data_Uscita date,
      @Genere varchar(12),
	  @CodiceFilm int output
AS
BEGIN
      SET NOCOUNT ON;
      INSERT INTO  Cinema.Film (Titolo, Anno, Regia, Durata, Data_Uscita, Genere)
      VALUES (@Titolo, @Anno, @Regia, @Durata, @Data_Uscita, @Genere)
      SET @CodiceFilm=SCOPE_IDENTITY()
      RETURN  @CodiceFilm
END
GO
/****** Object:  StoredProcedure [Cinema].[AddNewPrenotazione]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[AddNewPrenotazione]
      @DataOra datetime,
      @Username_UtenteFree varchar(30),
      @Codice_Evento int,
      @CodicePrenotazione int output
      
AS
BEGIN
      SET NOCOUNT ON;
      INSERT INTO  Cinema.Prenotazione (DataOra, Username_UtenteFree, Codice_Evento)
      VALUES (@DataOra, @Username_UtenteFree, @Codice_Evento)
      SET @CodicePrenotazione=SCOPE_IDENTITY()
      RETURN  @CodicePrenotazione
END
GO
/****** Object:  StoredProcedure [Cinema].[AddNewRiserva]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[AddNewRiserva]
      @codice_prenotazione int,
	  @numero_posto int
AS
BEGIN
      SET NOCOUNT ON;
     INSERT INTO  Cinema.Riserva(Numero_Posto, Codice_Prenotazione)
      VALUES (@codice_prenotazione, @numero_posto)
END
GO
/****** Object:  StoredProcedure [Cinema].[DeleteEvento]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[DeleteEvento]
      @CodiceEvento int
AS
BEGIN
    DELETE Cinema.[Evento]  
    WHERE CodiceEvento = @CodiceEvento
END
GO
/****** Object:  StoredProcedure [Cinema].[DeleteFilm]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[DeleteFilm]
      @CodiceFilm int
AS
BEGIN
    DELETE Cinema.[Film]  
    WHERE CodiceFilm = @CodiceFilm
END
GO
/****** Object:  StoredProcedure [Cinema].[DeletePrenotazione]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[DeletePrenotazione]
      @CodicePrenotazione int
AS
BEGIN
	/*
	 * Delete the Prenotation
	 */
    DELETE Cinema.[Prenotazione]
    WHERE CodicePrenotazione = @CodicePrenotazione

	/*
	 * Save the last value of the Primary Key and reset
	 * the Primary Key counters to the last value known.
	 */
	declare @maxPrenotation int;  
	select @maxPrenotation = max(CodicePrenotazione) from Cinema.Prenotazione;  
	dbcc checkident('Cinema.Prenotazione', reseed, @maxPrenotation);

	/*
	 * Delete the Reservation
	 */
	DELETE Cinema.[Riserva]
    WHERE Codice_Prenotazione = @CodicePrenotazione
END
GO
/****** Object:  StoredProcedure [Cinema].[DeleteUser]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[DeleteUser]
      @Username varchar(30)
AS
BEGIN
    DELETE Cinema.[UtenteFree]  
    WHERE UsernameUtenteFree = @Username;
END
GO
/****** Object:  StoredProcedure [Cinema].[EditUser]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[EditUser]
		@OldUsername varchar(30),
		@NewUsername varchar(30),
		@NewPassword varchar(32),
		@NewNome varchar(20),
		@NewCognome varchar(20)
AS
BEGIN
    UPDATE Cinema.[UtenteFree] 
	SET UsernameUtenteFree = @NewUsername, Password = @NewPassword, Nome = @NewNome, Cognome = @NewCognome
    WHERE UsernameUtenteFree = @OldUsername
END
GO
/****** Object:  StoredProcedure [Cinema].[RichiestaCodiceSala]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[RichiestaCodiceSala]
      @CodiceEvento int
AS
BEGIN
      SET NOCOUNT ON;
      SELECT E.Codice_Sala FROM Cinema.Evento AS E 
	  WHERE E.CodiceEvento = @CodiceEvento;
END
GO
/****** Object:  StoredProcedure [Cinema].[VisualizzaPostiRiservati]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[VisualizzaPostiRiservati]
      @codice_evento int
AS
BEGIN
      SET NOCOUNT ON;
      SELECT R.Numero_Posto, R.Codice_Prenotazione FROM Cinema.Evento AS E JOIN Cinema.Prenotazione AS P ON E.CodiceEvento = P.Codice_Evento
	  JOIN Cinema.Riserva AS R ON R.Codice_Prenotazione = P.CodicePrenotazione
	  WHERE E.CodiceEvento = @codice_evento;
END
GO
/****** Object:  StoredProcedure [Cinema].[VisualizzaPostiSala]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[VisualizzaPostiSala]
      @codice_evento int
AS
BEGIN
      SET NOCOUNT ON;
      SELECT P.NumeroPosto, P.Codice_Sala FROM Cinema.Evento AS E JOIN Cinema.Sala AS S ON E.Codice_Sala = S.CodiceSala
	  JOIN Cinema.Posto AS P ON P.Codice_Sala = S.CodiceSala
	  WHERE E.CodiceEvento = @codice_evento;
END
GO
/****** Object:  StoredProcedure [Cinema].[VisualizzaPrenotazione]    Script Date: 03/02/2020 13:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Cinema].[VisualizzaPrenotazione]
      @user varchar(30)
AS
BEGIN
      SET NOCOUNT ON;
  SELECT P.CodicePrenotazione,P.DataOra,P.Username_UtenteFree,
                            P.Codice_Evento,F.Titolo,E.DataOra,E.Codice_Sala,
                            E.Prezzo, R.Numero_Posto
                            FROM Cinema.Evento AS E JOIN Cinema.Prenotazione AS P ON E.CodiceEvento = P.Codice_Evento
                            JOIN Cinema.Film AS F ON E.Codice_Film = F.CodiceFilm 
							JOIN Cinema.Riserva AS R ON R.Codice_Prenotazione = P.CodicePrenotazione
                            WHERE P.Username_UtenteFree = @user;
END
GO
USE [master]
GO
ALTER DATABASE [Cinema] SET  READ_WRITE 
GO
