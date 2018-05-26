CREATE DATABASE Gestion_Vente_DB

On primary
(name = Gestion_Vente_DB_Dat,
filename = 'E:\Stage\Base de donner\Gestion_Vente_DB_Dat.mdf',
size = 10MB,
maxsize = 50MB,
filegrowth = 5%)

Log on
(name = Gestion_Vente_DB_Log,
filename = 'E:\Stage\Base de donner\Gestion_Vente_DB_Log.ldf',
size = 5MB,
maxsize = 25MB,
filegrowth = 5%)