/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF (NOT EXISTS(SELECT * FROM [dbo].[Department] WHERE Name = 'IT'))
BEGIN
    INSERT INTO [dbo].[Department](Name)
    VALUES('IT')
END

IF (NOT EXISTS(SELECT * FROM [dbo].[Department] WHERE Name = 'HR'))
BEGIN
    INSERT INTO [dbo].[Department](Name)
    VALUES('HR')
END

IF (NOT EXISTS(SELECT * FROM [dbo].[Department] WHERE Name = 'Engineering'))
BEGIN
    INSERT INTO [dbo].[Department](Name)
    VALUES('Engineering')
END