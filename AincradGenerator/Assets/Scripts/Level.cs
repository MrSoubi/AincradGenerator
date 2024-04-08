using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    enum TileType {
        FLOOR,
        DUNGEON,
        VILLAGE
    };

    TileType[,] grid;

    readonly int size;

    /// <summary>
    /// Generates a Level of the given level
    /// </summary>
    /// <param name="level"> Should be between 1 and 15</param>
    public Level(int level)
    {
        size = level;
        grid = new TileType[size, size];

        Initialize();
        SetVillage();
        SetDungeon();
    }

    /// <summary>
    /// Fills the grid with floor tiles
    /// </summary>
    private void Initialize()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                grid[i, j] = TileType.FLOOR;
            }
        }
    }

    private void SetDungeon()
    {
        bool isDungeonSet = false;

        while (!isDungeonSet)
        {
            Vector2Int position = GetRandomPosition();

            if (grid[position.x, position.y] == TileType.FLOOR)
            {
                grid[position.x, position.y] = TileType.DUNGEON;
                isDungeonSet = true;
            }
        }
    }

    private void SetVillage()
    {
        bool isVillageSet = false;

        while (!isVillageSet)
        {
            Vector2Int position = GetRandomPosition();

            if (grid[position.x, position.y] == TileType.FLOOR)
            {
                grid[position.x, position.y] = TileType.VILLAGE;
                isVillageSet = true;
            }
        }
    }

    private Vector2Int GetRandomPosition()
    {
        Vector2Int position = new Vector2Int();

        position.x = Mathf.FloorToInt(Randomizer.NextRandom() * size);
        position.y = Mathf.FloorToInt(Randomizer.NextRandom() * size);

        return position;
    }

}
