using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static void SaveRecord(int score)
    {
        int record = PlayerPrefs.GetInt("Record", 0);

        if (score > record)
        {
            PlayerPrefs.SetInt("Record", score);
        }
    }

    public static int LoadRecord()
    {
        return PlayerPrefs.GetInt("Record", 0);
    }
}
