using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float duration = 3;
    [SerializeField] private float moveSpeed = 10;
    private Transform player;
    PlayerHealth player_h;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if (transform.position.z < player.position.z - 500)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        player_h = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            Invulnerability(player_h);
        }
    }

    private void Invulnerability(PlayerHealth player)
    {
        Debug.Log("Invuln");
        player_h.SetInvulnerable(true);
        player_h.animationController.SetInvulnerable(true);

        Invoke("Destroyer", duration);

    }
    void Destroyer() {
        Debug.Log("Vuln");
        player_h.SetInvulnerable(false);
        player_h.animationController.SetInvulnerable(false);

        Destroy(gameObject);
    }

}


    
