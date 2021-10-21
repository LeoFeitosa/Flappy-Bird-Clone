using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private Transform headTransform;
    public Vector2 Head => headTransform.position;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(Head, Vector3.one * 0.25f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            player.Die();
        }
    }
}
