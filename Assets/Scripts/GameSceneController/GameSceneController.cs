using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Determines sequence of events on GameLevel scene, such as victory conditions.
/// Serves as mediator for other classes which are used in determening whether the player has reached victory conditions. 
/// </summary>
public class GameSceneController : MonoBehaviour
{
    [Header("Level Parameters:")]
    [SerializeField] private string SceneToLoadName = "MainScreen";
    [SerializeField] private float LevelEndDelay = 2.0f;
    [Header("Victory conditions classes:")]
    [SerializeField] private FallDetector FallDetector = null;
    [SerializeField] private GameObjectsCounter CubesCounter = null;
    [SerializeField] private LayerMask Layer = default;
    private int CubesLeft = 0;
    private void Start()
    {
        CubesLeft = CubesCounter.FindGameObjectsOnLayer(Layer.value);
        FallDetector.FallDetected += () =>
        {
            CubesLeft--;
            if (CubesLeft <= 0)
            {
                StartCoroutine(EndLevel());
            }
        };
    }
    private IEnumerator EndLevel()
    {
        yield return new WaitForSeconds(LevelEndDelay);
        SceneManager.LoadScene(SceneToLoadName);
    }
}
