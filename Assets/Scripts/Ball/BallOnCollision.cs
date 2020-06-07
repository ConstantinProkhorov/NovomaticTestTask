using UnityEngine;
/// <summary>
/// Logic for ball reaction on collision with other game objects.
/// </summary>
public class BallOnCollision : MonoBehaviour
{
    [SerializeField] ParticleSystem DestructionEffect = null;
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(DestructionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
