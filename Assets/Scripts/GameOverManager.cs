using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private Text Title;
    [SerializeField] private Text Time;
    [SerializeField] private Transform deathScene;
    [SerializeField] private Transform winScene;
    void Start()
    {
        if(GameValues.isLoss){
            winScene.gameObject.SetActive(false);
            Title.text = "Game Over";
            Time.text = "You Died";
            Title.color = Color.red;
            Time.color = Color.red;
        }else{
            deathScene.gameObject.SetActive(false);
            Title.text = "You Win";
            Title.color = Color.black;
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
            Time.text = timerText;
            Time.color = Color.black;
        }
    }
}
