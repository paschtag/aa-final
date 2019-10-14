using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showData : MonoBehaviour
{
    public Text NameText = null;
    public Text LivesText;
    public Text PanelSpeedText;
    public Text lcoreText;
    public Text HighScoreText;
    public Text RoundsText;

    private void Awake()
    {
        NameText.text = keepData.PlayerName;
        LivesText.text = keepData.PlayerLives.ToString();
        //SpeedText.text = keepData.PlayerSpeed.ToString();
        HighScoreText.text = "High: " + keepData.HighScore.ToString();
        RoundsText.text = "Rounds: " + keepData.RoundsPlayed.ToString();
    }


    private void Update()
    {
     //   ScoreText.text = Score.PinCount.ToString();
    }
}
