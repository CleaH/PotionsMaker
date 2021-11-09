USE master
GO

IF DB_ID('PotionMaker') IS NOT NULL
    DROP DATABASE PotionMaker
GO

CREATE DATABASE PotionMaker
GO

USE PotionMaker
GO

CREATE TABLE Ingredient (
    ingredient_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    nom VARCHAR(50),
    descriptionIngredient text,
    imageIngredient image,
    R INT,
    V INT,
    B INT,
    toxicity INT,
    soin INT,
    amour INT,
    puissance INT,
    mana INT,
    intelligence INT,
    agilite INT,
    taux_reussite DECIMAL(2,1)
)
GO