using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Logic for reloadin current scene.
/// </summary>
public class SceneReload : MonoBehaviour
{
    /// <summary>
    /// Reloads the scene this monoBehaviour is in. 
    /// </summary>
    public void ReloadScene()
    {
        SceneManager.LoadScene(gameObject.scene.buildIndex);
    }
}
