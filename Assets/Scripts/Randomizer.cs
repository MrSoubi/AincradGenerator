using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Randomizer
{
    /// <summary>
    /// Initialize the randomizer with a seed
    /// </summary>
    /// <param name="seed"></param>
    static public void Initialize(string seed)
    {
        int intSeed = 0;

        foreach (char c in seed)
        {
            intSeed += c;
        }

        Random.InitState(intSeed);
    }

    /// <summary>
    /// Returns a random float between 0 and 1 (inclusive)
    /// </summary>
    /// <returns></returns>
    static public float NextRandom()
    {
        return Random.Range(0f, 1f);
    }
}
