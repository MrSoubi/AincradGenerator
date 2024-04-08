using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    const int TILE_SIZE = 16;

    [SerializeField] TMP_InputField seedInputField;
    List<Level> levels = new List<Level>();

    public void GenerateWorld()
    {
        Randomizer.Initialize(seedInputField.text);

        for (int i = 0; i < 15; i++)
        {
            levels.Add(new Level(i));
        }
    }

    public void DisplayLevel(int level)
    {

    }
}
