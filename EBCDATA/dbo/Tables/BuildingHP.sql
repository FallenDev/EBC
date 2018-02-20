CREATE TABLE BuildingHP (
    [level] INT NOT NULL,
    [townHall] FLOAT,
    [vault] FLOAT,
    [goldMine] FLOAT,
    [alchemy] FLOAT,
    [reaper] FLOAT,
    [sniper] FLOAT,
    [airDefense] FLOAT,
    [magicTower] FLOAT,
    [ermah] FLOAT,
    [mortar] FLOAT,
    [cannon] FLOAT,
    [sanctum] FLOAT,
    [victoryStatue] FLOAT, 
    CONSTRAINT [PK_BuildingHP] PRIMARY KEY ([level])
);