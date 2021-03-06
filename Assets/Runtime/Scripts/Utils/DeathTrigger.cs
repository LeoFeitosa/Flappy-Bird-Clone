using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class DeathTrigger : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null && !player.IsDead)
        {
            player.Die();
        }
    }
}
