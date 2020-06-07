using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Class for buttons to load new scene. 
/// </summary>
public class SceneLoader : MonoBehaviour
{
    /// <summary>
    /// Loads scene by name which is passed as parameter.
    /// </summary>
    public void Load(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }  
}
