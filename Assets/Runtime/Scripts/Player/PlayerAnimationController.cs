using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private PlayerController playerController;
    private static readonly int velocityYId = Animator.StringToHash("SpeedY");

    void Awake()
    {
        playerController = GetComponent<PlayerController>();
    }

    void LateUpdate()
    {
        animator.SetFloat(velocityYId, playerController.Velocity.y);
    }

    public void Die()
    {
        animator.enabled = false;
        enabled = false;
    }
}
