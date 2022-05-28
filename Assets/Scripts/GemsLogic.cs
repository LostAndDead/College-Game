using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GemsLogic : MonoBehaviour
{
    [SerializeField] private int SpawnThreashold;
    private bool collected = false;
    void Start()
    {
        if(GameValues.Difficulty < SpawnThreashold){
            Destroy(this.gameObject);
        }else
        {
            GameValues.totalCoins += 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(!collected){
            collected = true;
            Destroy(this.gameObject);
            GameValues.Score = GameValues.Score + 1;
            if(GameValues.totalCoins == GameValues.Score){
                GameValues.isLoss = false;
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
        }
    }
}