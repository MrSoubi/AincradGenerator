using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    const int TILE_SIZE = 16;

    [SerializeField] TMP_InputField seedInputField;
    List<Level> levels = new List<Level>();

    [SerializeField] Tilemap tilemap;

    [SerializeField] TileBase tileFloor;
    [SerializeField] TileBase tileDungeon;
    [SerializeField] TileBase tileVillage;

    [SerializeField] Canvas worldGenerationUI;

    private void Start()
    {
        tilemap = GetComponentInChildren<Tilemap>();
    }

    public void GenerateWorld()
    {
        Randomizer.Initialize(seedInputField.text);

        for (int i = 0; i < 15; i++)
        {
            levels.Add(new Level(i+1));
        }

        DisplayLevel(1);
    }

    public void DisplayLevel(int level)
    {
        for (int i = 0; i < levels[level-1].size; i++)
        {
            for (int j = 0; j < levels[level - 1].size; j++)
            {
                tilemap.SetTile(new Vector3Int(i, j, 0), tileFloor);
            }
        }

        worldGenerationUI.enabled = false;
        tilemap.RefreshAllTiles();

    }
}
