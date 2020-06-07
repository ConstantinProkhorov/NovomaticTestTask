using System.Collections;
using UnityEngine;
/// <summary>
/// Every DistanceCheckDelay seconds checks if ball traveled more than DestructionDistance from main camera.
/// If so destroys the ball.
/// </summary>
public class BallDestructor : MonoBehaviour
{
    [Header("Destruction parameters:")]
    [SerializeField] float DistanceCheckDelay = 4.0f;
    [SerializeField] float DestructionDistance = 60.0f;
    private float CameraZPosition;
    private void Start()
    {
        CameraZPosition = Camera.main.transform.position.z;
        StartCoroutine(DistanceBasedDestruction());
    }
    private IEnumerator DistanceBasedDestruction()
    {
        yield return new WaitForSeconds(DistanceCheckDelay);
        if ((transform.position.z - CameraZPosition) > DestructionDistance)
        {
            Destroy(gameObject);
        }
        StartCoroutine(DistanceBasedDestruction());
    }
}
