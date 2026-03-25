using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDcontroller : MonoBehaviour
{
    [SerializeField] private PlayerHealth health;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI recordText;

    private void Update()
    {
        healthText.text = "HP: " + health.currentHealth;
        scoreText.text = "Score: " + Mathf.FloorToInt(ScoreSystem.Instance.Score);
        recordText.text = "Record: " + SaveSystem.LoadRecord();
    }
}
