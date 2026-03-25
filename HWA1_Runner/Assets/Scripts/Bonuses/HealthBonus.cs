using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBonus : MonoBehaviour
{
    [SerializeField] private float healAmount = 20;
    [SerializeField] private float moveSpeed = 10;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if (transform.position.z < player.position.z - 12)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();
        Debug.Log("Healed " + player.currentHealth);

        if (player != null)
        {
            player.Heal(healAmount);
            Destroy(gameObject);
        }
    }
}
