using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    [SerializeField] private Text gems;
    [SerializeField] private Text lives;
    [SerializeField] private Text timer;

    private void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicManager>().PlayMusic();
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicManager>().SwapTrackToLevel();
    }

    void Update()
    {
        gems.text = GameValues.Score.ToString() + "/" + GameValues.totalCoins.ToString();
        lives.text = GameValues.Lives.ToString();
    }

    void FixedUpdate()
    {
        GameValues.secondsCount += Time.deltaTime;
        if(GameValues.secondsCount >= 60){
            GameValues.minuteCount++;
            GameValues.secondsCount = 0;
        }

        string timerText = "";
        if(GameValues.minuteCount < 10){
            timerText += "0" + GameValues.minuteCount;
        }else{
            timerText += GameValues.minuteCount;
        }
        timerText += ":";
        if(GameValues.secondsCount < 10){
            timerText += "0" + (int)GameValues.secondsCount;
        }else{
            timerText += (int)GameValues.secondsCount;
        }
        timer.text = timerText;
    }
}
