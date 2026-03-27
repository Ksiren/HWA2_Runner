using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private bool isInvulnerable = false;

    public float currentHealth;
    public PlayerAnimationController animationController;

    private void Start()
    {
        currentHealth = maxHealth;
        animationController = GetComponent<PlayerAnimationController>();
    }

    public void TakeDamage(float damage)
    {
        if (isInvulnerable) return;

        animationController.PlayDamage();

        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            animationController.PlayDeath();
            Die();
        }

        Debug.Log(currentHealth);
    }

    private void Die()
    {
        Debug.Log("Dead");
        SaveSystem.SaveRecord(ScoreSystem.Instance.Score);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Heal(float amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
    }

    public void SetInvulnerable(bool value)
    {
        isInvulnerable = value;
    }
}