USE Gestion_Vente_DB

CREATE PROCEDURE SP_LOGIN

	@USERNAME VARCHAR(50), @PSW VARCHAR(50)

AS

SELECT * FROM USERS WHERE USERNAME = @USERNAME AND PSW = @PSW

/* ------------------------------------------- */

CREATE PROCEDURE All_Categorie
AS
SELECT * FROM CATEGORIE

/* ------------------------------------------- */

CREATE PROCEDURE ADD_PRODUCT
	@ID_PRODUIT INT, @ID_CAT INT, @NOM_PRODUIT VARCHAR(40), @QTE_STOCK INT, @PRIX VARCHAR(25), @IMG_PRODUIT IMAGE
AS
INSERT INTO [PRODUIT]
           ([ID_PRODUIT]
		   ,[ID_CAT]
           ,[NOM_PRODUIT]
           ,[QTE_STOCK]
           ,[PRIX]
           ,[IMG_PRODUIT])
     VALUES
           (@ID_PRODUIT
		   ,@ID_CAT
           ,@NOM_PRODUIT
           ,@QTE_STOCK
           ,@PRIX
           ,@IMG_PRODUIT)

/* ------------------------------------------- */

CREATE PROCEDURE VERIFYPRODUCTID
	@ID INT
AS
SELECT * FROM PRODUIT WHERE ID_PRODUIT = @ID

/* ------------------------------------------- */

ALTER PROCEDURE All_Product
AS
SELECT [ID_PRODUIT] as [ID du Produit]
      ,[DESCRIPTION_CAT] as [Catégories]
      ,[NOM_PRODUIT] as [Descriptions du Produit]
      ,[QTE_STOCK] as [Quantité Stockée]
      ,[PRIX] as [Prix du Produit]
  FROM [dbo].[PRODUIT]
  INNER JOIN CATEGORIE
  ON CATEGORIE.ID_CAT = PRODUIT.ID_CAT

/* ------------------------------------------- */

ALTER PROCEDURE Search_Produit
	@ID VARCHAR(50)
AS
SELECT [ID_PRODUIT] as [ID du Produit]
      ,[DESCRIPTION_CAT] as [Catégories]
      ,[NOM_PRODUIT] as [Descriptions du Produit]
      ,[QTE_STOCK] as [Quantité Stockée]
      ,[PRIX] as [Prix du Produit]
  FROM [dbo].[PRODUIT]
  INNER JOIN CATEGORIE
  ON CATEGORIE.ID_CAT = PRODUIT.ID_CAT
 WHERE CONVERT(varchar, [ID_PRODUIT]) +
	   [DESCRIPTION_CAT] +
	   [NOM_PRODUIT] +
	   CONVERT(varchar, [QTE_STOCK]) +
	   [PRIX] 
	   LIKE '%' + @ID + '%'

/* ------------------------------------------- */

CREATE PROCEDURE DELETE_PRODUIT
	@ID int
AS
DELETE FROM PRODUIT WHERE ID_PRODUIT = @ID

/* ------------------------------------------- */

CREATE PROCEDURE GET_IMG_PRODUCT
	@ID INT
AS
SELECT IMG_PRODUIT FROM PRODUIT WHERE ID_PRODUIT = @ID

/* ------------------------------------------- */

ALTER PROCEDURE UPDATE_PRODUIT
	@ID_PRODUIT INT, @ID_CAT INT, @NOM_PRODUIT VARCHAR(40),
    @QTE_STOCK INT, @PRIX VARCHAR(25), @IMG_PRODUIT IMAGE
AS
UPDATE PRODUIT
SET ID_PRODUIT = @ID_PRODUIT, ID_CAT = @ID_CAT, NOM_PRODUIT = @NOM_PRODUIT,
    QTE_STOCK = @QTE_STOCK, PRIX = @PRIX, IMG_PRODUIT = @IMG_PRODUIT
WHERE ID_PRODUIT = @ID_PRODUIT

/* ------------------------------------------- */

CREATE PROCEDURE SINGLE_PRODUCT
	@ID INT
AS
SELECT [ID_PRODUIT]
      ,[DESCRIPTION_CAT]
      ,[NOM_PRODUIT]
      ,[QTE_STOCK]
      ,[PRIX]
      ,[IMG_PRODUIT]
FROM [dbo].[PRODUIT]
INNER JOIN CATEGORIE
ON CATEGORIE.ID_CAT = PRODUIT.ID_CAT
WHERE ID_PRODUIT = @ID

/* ------------------------------------------- */

CREATE PROCEDURE [dbo].[RPT_All_Product]
AS
SELECT [ID_PRODUIT] as [ID du Produit]
      ,[DESCRIPTION_CAT] as [Catégories]
      ,[NOM_PRODUIT] as [Descriptions du Produit]
      ,[QTE_STOCK] as [Quantité Stockée]
      ,[PRIX] as [Prix du Produit]
	  ,[IMG_PRODUIT] as [Image du Produit]
  FROM [dbo].[PRODUIT]
  INNER JOIN CATEGORIE
  ON CATEGORIE.ID_CAT = PRODUIT.ID_CAT

/* ------------------------------------------- */

ALTER PROCEDURE [dbo].[SINGLE_CATEGORIE]
@ID INT
AS
	SELECT P.*, CA.DESCRIPTION_CAT FROM PRODUIT P
		JOIN
	CATEGORIE CA ON CA.ID_CAT = P.ID_CAT
	WHERE CA.ID_CAT = @ID
RETURN
GO

/* ------------------------------------------- */

CREATE PROCEDURE Search_Categorie
	@ID VARCHAR(50)
AS
SELECT [ID_CAT] as [ID du Catégorie]
      ,[DESCRIPTION_CAT] as [Catégories]
  FROM [dbo].[CATEGORIE]
 WHERE CONVERT(varchar, [ID_CAT]) +
	   [DESCRIPTION_CAT] LIKE '%' + @ID + '%'

/* ------------------------------------------- */

CREATE PROCEDURE ALL_CITY
AS
SELECT * FROM CITY

/* ------------------------------------------- */

ALTER PROCEDURE [dbo].[ADD_COSTOMERS]
	@NOM_CLIENT VARCHAR(30), @PRN_CLIENT VARCHAR(30), @TEL_CLIENT INT, @EMAIL VARCHAR(50),
	@IMAGE_CLIENT IMAGE, @CITY_ID INT--, @CRITERION VARCHAR(50)
AS
--IF @CRITERION = 'WITH_IMAGE'
--BEGIN
INSERT INTO [CLIENT]
           ([NOM_CLIENT]
           ,[PRN_CLIENT]
           ,[TEL_CLIENT]
           ,[EMAIL]
           ,[IMAGE_CLIENT]
           ,[CITY_ID])
     VALUES
           (@NOM_CLIENT
           ,@PRN_CLIENT
           ,@TEL_CLIENT
           ,@EMAIL
           ,@IMAGE_CLIENT
           ,@CITY_ID)
--END
/*IF @CRITERION = 'WITHOT_IMAGE'
BEGIN
INSERT INTO [CLIENT]
           ([NOM_CLIENT]
           ,[PRN_CLIENT]
           ,[TEL_CLIENT]
           ,[EMAIL]
           ,[CITY_ID])
     VALUES
           (@NOM_CLIENT
           ,@PRN_CLIENT
           ,@TEL_CLIENT
           ,@EMAIL
           ,@CITY_ID)
END
*/
/* ------------------------------------------- */

CREATE PROCEDURE ALL_CUSTOMERS
AS
SELECT [ID_CLIENT]
      ,[NOM_CLIENT] AS 'Nom'
      ,[PRN_CLIENT] AS 'Prénom'
      ,[TEL_CLIENT] AS 'Téléphone'
      ,[EMAIL] AS 'Email'
      ,[CITY_NAME] AS 'Ville'
  FROM CLIENT
  INNER JOIN CITY
  ON CITY.CITY_ID = CLIENT.CITY_ID

/* ------------------------------------------- */

ALTER PROCEDURE [UPDATE_COSTOMERS]
	@NOM_CLIENT VARCHAR(30), @PRN_CLIENT VARCHAR(30), @TEL_CLIENT INT, @EMAIL VARCHAR(50),
	@IMAGE_CLIENT IMAGE, @CITY_ID INT, @ID INT
AS
UPDATE [dbo].[CLIENT]
   SET [NOM_CLIENT] = @NOM_CLIENT
      ,[PRN_CLIENT] = @PRN_CLIENT
      ,[TEL_CLIENT] = @TEL_CLIENT
      ,[EMAIL] = @EMAIL
      ,[IMAGE_CLIENT] = @IMAGE_CLIENT
      ,[CITY_ID] = @CITY_ID
 WHERE ID_CLIENT = @ID

/* ------------------------------------------- */

CREATE PROCEDURE GET_IMG_CLIENT
	@ID INT
AS
SELECT IMAGE_CLIENT FROM CLIENT WHERE ID_CLIENT = @ID

/* ------------------------------------------- */

CREATE PROCEDURE DELETE_CLIENT
	@ID INT
AS
DELETE FROM CLIENT WHERE ID_CLIENT = @ID

/* ------------------------------------------- */

CREATE PROCEDURE SEARCH_CLIENT
	@ID VARCHAR(50)
AS
SELECT [ID_CLIENT]
      ,[NOM_CLIENT] AS 'Nom'
      ,[PRN_CLIENT] AS 'Prénom'
      ,[TEL_CLIENT] AS 'Téléphone'
      ,[EMAIL] AS 'Email'
      ,[CITY_NAME] AS 'Ville'
  FROM CLIENT
  INNER JOIN CITY
  ON CLIENT.CITY_ID = CITY.CITY_ID
  WHERE [NOM_CLIENT] + [PRN_CLIENT] + [EMAIL] + [CITY_NAME] LIKE '%' + @ID + '%'

/* ------------------------------------------- */

CREATE PROCEDURE LASR_COMMANDE_ID
AS
SELECT ISNULL(MAX(ID_CMD) + 1, 1) FROM COMMANDE

/* ------------------------------------------- */

ALTER PROCEDURE VERIFY_QTE
	@ID_PRODUIT INT, @QTE_ENTRER INT
AS
SELECT * FROM PRODUIT WHERE ID_PRODUIT = @ID_PRODUIT AND QTE_STOCK >= @QTE_ENTRER

/* ------------------------------------------- */

ALTER PROCEDURE GETORDERDETAIL
	@ID_ORDER INT
AS
SELECT PRODUIT.[ID_PRODUIT] AS 'ID Produit'
	  ,PRODUIT.NOM_PRODUIT AS 'Nom Produit'
      ,COMMANDE.[ID_CMD] AS 'ID Facturation'
      ,[QUANTITE] AS 'Quantitée'
      ,[PRICE] AS 'Prix'
      ,[DISCOUNT] AS 'Taux Actualisation'
      ,CONVERT(FLOAT,[AMOUNT]) AS 'Montant'
      ,CONVERT(FLOAT, [TOTAL_AMOUNT]) AS 'Montant Totale'
	  ,DATE_CMD AS 'Date de la Vente'
	  ,DESCRIPTION_CMD AS 'Description du facture'
	  ,NOM_VENDU AS 'Nom du Vendeur'
	  ,CLIENT.ID_CLIENT AS 'ID Client'
	  ,NOM_CLIENT + ' ' + PRN_CLIENT AS 'NOM CLIENT'
	  ,TEL_CLIENT AS 'Téléphone'
	  ,EMAIL AS 'Email'
	  ,CITY_NAME AS 'Ville'
  FROM [dbo].[DETAIL_CMD]
  INNER JOIN COMMANDE
  ON COMMANDE.ID_CMD = DETAIL_CMD.ID_CMD
  INNER JOIN CLIENT
  ON CLIENT.ID_CLIENT = COMMANDE.ID_CLIENT
  INNER JOIN CITY
  ON CLIENT.CITY_ID = CITY.CITY_ID
  INNER JOIN PRODUIT
  ON PRODUIT.ID_PRODUIT = DETAIL_CMD.ID_PRODUIT
  WHERE DETAIL_CMD.ID_CMD = @ID_ORDER

  /* ------------------------------------------- */

ALTER PROCEDURE GETORDERDETAILFORPRINT
AS
SELECT PRODUIT.[ID_PRODUIT] AS 'ID Produit'
	  ,PRODUIT.NOM_PRODUIT AS 'Nom Produit'
      ,COMMANDE.[ID_CMD] AS 'ID Facturation'
      ,[QUANTITE] AS 'Quantitée'
      ,[PRICE] AS 'Prix'
      ,[DISCOUNT] AS 'Taux Actualisation'
      ,CONVERT(FLOAT,[AMOUNT]) AS 'Montant'
      ,CONVERT(FLOAT, [TOTAL_AMOUNT]) AS 'Montant Totale'
	  ,DATE_CMD AS 'Date de la Vente'
	  ,DESCRIPTION_CMD AS 'Description du facture'
	  ,NOM_VENDU AS 'Nom du Vendeur'
	  ,CLIENT.ID_CLIENT AS 'ID Client'
	  ,NOM_CLIENT + ' ' + PRN_CLIENT AS 'NOM CLIENT'
	  ,TEL_CLIENT AS 'Téléphone'
	  ,EMAIL AS 'Email'
	  ,CITY_NAME AS 'Ville'
  FROM [dbo].[DETAIL_CMD]
  INNER JOIN COMMANDE
  ON COMMANDE.ID_CMD = DETAIL_CMD.ID_CMD
  INNER JOIN CLIENT
  ON CLIENT.ID_CLIENT = COMMANDE.ID_CLIENT
  INNER JOIN CITY
  ON CLIENT.CITY_ID = CITY.CITY_ID
  INNER JOIN PRODUIT
  ON PRODUIT.ID_PRODUIT = DETAIL_CMD.ID_PRODUIT

/* ------------------------------------------- */

CREATE PROCEDURE [dbo].[LASR_ORDER_FOR_PRINT]
AS
SELECT MAX(ID_CMD) FROM COMMANDE

/* ------------------------------------------- */

ALTER PROCEDURE SEARCH_COMMANDE
	@ID VARCHAR(50)
AS
SELECT [ID_CMD] AS 'ID Commande'
      ,[NOM_CLIENT] + ' ' + [PRN_CLIENT] AS 'Nom Client'
      ,[DATE_CMD] AS 'Date Commande'
      ,[DESCRIPTION_CMD] AS 'Description Commande'
      ,[NOM_VENDU] AS 'Nom du Vendeur'
  FROM [dbo].[COMMANDE]
  INNER JOIN CLIENT
  ON CLIENT.ID_CLIENT = COMMANDE.ID_CLIENT
  WHERE CONVERT(VARCHAR, ID_CMD) + NOM_CLIENT + PRN_CLIENT + NOM_VENDU LIKE '%' + @ID + '%'

/* ------------------------------------------- */

CREATE PROCEDURE ALL_COMMANDE
AS
SELECT [ID_CMD] AS 'ID Commande'
      ,[NOM_CLIENT] + ' ' + [PRN_CLIENT] AS 'Nom Client'
      ,[DATE_CMD] AS 'Date Commande'
      ,[DESCRIPTION_CMD] AS 'Description Commande'
      ,[NOM_VENDU] AS 'Nom du Vendeur'
  FROM [dbo].[COMMANDE]
  INNER JOIN CLIENT
  ON CLIENT.ID_CLIENT = COMMANDE.ID_CLIENT

/* ------------------------------------------- */

CREATE PROCEDURE DELETE_Commande
	@ID int
AS
DELETE FROM COMMANDE WHERE ID_CMD = @ID

/* ------------------------------------------- */

CREATE PROCEDURE ADD_USER
	@USERNAME VARCHAR(50), @NAME VARCHAR(50), @PSW VARCHAR(50), @USERTYPE VARCHAR(50)
AS
INSERT INTO [USERS]
           ([USERNAME]
           ,[PSW]
           ,[USERTYPE]
           ,[NAME])
     VALUES
           (@USERNAME
           ,@PSW
           ,@USERTYPE
           ,@NAME)

/* ------------------------------------------- */

CREATE PROCEDURE ALL_USER
AS
SELECT [USERNAME] as 'Nom Utilisateur'
      ,[NAME] as 'Nom Complet'
      ,[PSW] as 'Mot de Passe'
      ,[USERTYPE] as 'Type Utilisateur'
  FROM [USERS]

/* ------------------------------------------- */

ALTER PROCEDURE SEARCH_USER
	@ID VARCHAR(50)
AS
SELECT [USERNAME] as 'Nom Utilisateur'
	  ,[NAME] as 'Nom Complet'
      ,[PSW] as 'Mot de Passe'
      ,[USERTYPE] as 'Type Utilisateur'
  FROM [USERS]
  WHERE USERNAME + NAME + USERTYPE LIKE '%' + @ID + '%'

/* ------------------------------------------- */

ALTER PROCEDURE UPDATE_USER
	@USERNAME VARCHAR(50), @NAME VARCHAR(50), @PSW VARCHAR(50), @USERTYPE VARCHAR(50)
AS
UPDATE [USERS]
   SET [NAME] = @NAME
      ,[PSW] = @PSW
      ,[USERTYPE] = @USERTYPE
 WHERE USERNAME = @USERNAME

 /* ------------------------------------------- */

 CREATE PROCEDURE DELETE_USER
	@USERNAME VARCHAR(50)
AS
DELETE FROM [USERS]
WHERE USERNAME = @USERNAME

 /* ------------------------------------------- */
