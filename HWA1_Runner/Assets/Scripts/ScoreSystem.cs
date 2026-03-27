using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem Instance;

    [SerializeField] private int scorePerSecond = 5;

    private float score;

    public int Score => Mathf.FloorToInt(score);

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        score += scorePerSecond * Time.deltaTime;
    }
}
