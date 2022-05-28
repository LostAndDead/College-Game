using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikesLogic : MonoBehaviour
{
    [SerializeField] private int SpawnThreashold;
    
    void Start()
    {
        if(GameValues.Difficulty < SpawnThreashold){
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (GameValues.damageCoolDown <= 0){
            GameValues.damageCoolDown = 50;
            GameValues.Lives = GameValues.Lives - 1;
            GameObject.Find("Player").SendMessage("Spawn");
            if(GameValues.Lives <= 0){
                GameValues.isLoss = true;
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
        }
        
    }
}
