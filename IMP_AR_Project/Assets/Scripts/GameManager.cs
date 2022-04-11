using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Timer;
    public Text ScoreCount;
    public Player Player;

    public int Score = 0;

    public static GameManager instance;

    public GameObject GameOver;

    public float TimeLimit = 10f;

    // Check the gameStatus
    // 0 = Main
    // 1 = Play
    // 2 = Play Checked
    public int gamestatus = 0;

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        // When Game Status is Play mode
        if (GameManager.instance.gamestatus >= 1)
        {
            TimeLimit -= Time.deltaTime;
            ScoreCount.text = Score.ToString() + " Kills";

            // if Player were dead
            if (Player.HP <= 0)
            {
                GameOver.gameObject.SetActive(true);
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
            }
        }
    }
}
