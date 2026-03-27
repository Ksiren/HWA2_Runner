using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayDamage()
    {
        animator.SetTrigger("Damage");
    }

    public void PlayBonus()
    {
        animator.SetTrigger("Bonus");
    }

    public void SetInvulnerable(bool value)
    {
        animator.SetBool("Invulnerable", value);
    }

    public void PlayDeath()
    {
        animator.SetTrigger("Death");
    }
}
