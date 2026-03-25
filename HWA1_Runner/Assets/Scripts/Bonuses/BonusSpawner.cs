using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] bonuses;
    [SerializeField] private float spawnInterval = 5;
    [SerializeField] private float spawnDistance = 30;

    private Transform player;
    private float timer;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            Spawn();
            timer = 0;
        }
    }

    void Spawn()
    {
        int lane = Random.Range(-1, 2);

        Vector3 pos = new Vector3( lane * 3, 1, player.position.z + spawnDistance);

        Instantiate(bonuses[Random.Range(0, bonuses.Length)], pos, Quaternion.identity);
    }

}
