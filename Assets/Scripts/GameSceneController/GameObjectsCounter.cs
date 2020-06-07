using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Counts game objects present on specified layer.
/// </summary>
public class GameObjectsCounter : MonoBehaviour
{
    /// <summary>
    /// Finds all game object on specified layer. 
    /// </summary>
    /// <param name="targetLayer">Target Layer.value. Converts from bitmask to layer number automatically.</param>
    /// <returns>Number of game object on specified layer.</returns>
    public int FindGameObjectsOnLayer(int targetLayer)
    {
        targetLayer = ToLayer(targetLayer);
        GameObject[] gameObjects = FindObjectsOfType<GameObject>();
        List<GameObject> list = new List<GameObject>();
        foreach (GameObject item in gameObjects)
        {
            if (item.layer == targetLayer)
            {
                list.Add(item);
            }
        }
        return list.Count;
    }
    /// <summary> 
    /// Converts given bitmask to layer number. 
    /// </summary>
    /// <returns>Layer number.</returns>
    private int ToLayer(int bitmask)
    {
        int result = bitmask > 0 ? 0 : 31;
        while (bitmask > 1)
        {
            bitmask = bitmask >> 1;
            result++;
        }
        return result;
    }
}
