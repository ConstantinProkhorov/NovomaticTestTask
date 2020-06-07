using System;
using UnityEngine;
/// <summary>
/// Sends an event when its collider was hit by the cube.
/// Does not interact with the ball. 
/// Layer collision matrix is used to distinguis ball from cubes. 
/// </summary>
public class FallDetector : MonoBehaviour
{
    /// <summary>
    /// Fired every time FallDetector collider is hit by cube. 
    /// </summary>
    public event Action FallDetected;
    private void OnTriggerEnter(Collider other)
    {
        FallDetected?.Invoke();
    }        
}
