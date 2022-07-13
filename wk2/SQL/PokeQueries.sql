-- double hyphen denotes a comment

/* provides multi
line 
comments */

/*
DDL - Data Definition Language
manipulat the state/structure (the tables) of our database

CREATE
ALTER
DROP


DML - Data Manipulation Language
manupulate the data/content of our database

INSERT
UPDATE
TRUNCATE
DELETE


DCL - Data Control Language
administrating who can access or manipulate the database

GRANT/REVOKE USER
GRANT/REVOKE LOGIN


DQL - Data Query Language
the commands we use to phrase, filter, and structure a query

SELECT
WHERE
FROM
IF
JOINS - linking the keys in multiple tables to return more relevent data to a query

*/
-- CREATE TABLE NAME
-- (
--    column descriptions
-- )
-- VERB NOUN 


-- DROP TABLE PokemonType;
-- DROP TABLE Pokemon;
-- DROP TABLE Type;


CREATE TABLE Pokemon
(
--  column-name variable-type modifiers
    Id INT PRIMARY KEY IDENTITY, -- not null and unique , identity == index
    Name NVARCHAR(64) NOT NULL UNIQUE,
    Height INT NOT NULL,
    Weight INT NOT NULL
);

CREATE TABLE Type
(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(64) NOT NULL UNIQUE
);

/* Multiplicity - the relationsips between the entries in a database/tables

1-to-1 - for each entry in table A, there is one (and only one) related entry in table B
1-to-many - for each entry in table A, there is/are many related entries in table B
many-to-many - for many entries in table A, there are many related entries in table B
*/

-- create a linking table between Pokemon and Type

CREATE TABLE PokemonType
(
    Id INT NOT NULL PRIMARY KEY IDENTITY,
    PokemonId INT NOT NULL FOREIGN KEY REFERENCES Pokemon (Id)
        ON DELETE CASCADE,
    TypeId INT NOT NULL FOREIGN KEY REFERENCES Type (Id)
        ON DELETE CASCADE
);

-- CASCADE triggers the specified column to also delete/update when the FK entry is affected


-- Insert data into the tables

INSERT INTO Pokemon (Name, Height, Weight) VALUES
('Charizard', 67, 215),
('Mudkip', 24, 45);


INSERT INTO Type (Name) VALUES
('Fire'),
('Water'),
('Dragon'),
('Grass');