using UnityEngine;
/// <summary>
/// Moves ball using Rigidbody.AddForce().
/// Ball is moved along it's local Z axis.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class BallMover : MonoBehaviour
{
    [Tooltip("Speed multiplier.")]
    [SerializeField] private float Speed = 10f;
    [SerializeField] Rigidbody Rigidbody = null;
    private void Start()
    {
        if (Rigidbody == null)
        {
            Rigidbody = gameObject.AddComponent<Rigidbody>();
        }
        Rigidbody.AddForce(transform.forward * Speed, ForceMode.VelocityChange);
    }
}
