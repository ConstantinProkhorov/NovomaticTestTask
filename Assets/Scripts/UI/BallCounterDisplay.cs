using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Displays current ball count.
/// Utilises scriptable object to achieve low coupling.
/// </summary>
public class BallCounterDisplay : MonoBehaviour
{
    [SerializeField] private Text BallCountText = null;
    [SerializeField] private IntegerValue BallCounter = null;
    private void Start()
    {
        BallCountText.text = BallCounter.ToString();
    }
}
