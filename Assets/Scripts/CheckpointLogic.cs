using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointLogic : MonoBehaviour
{
    [SerializeField] private int SpawnThreashold;
    [SerializeField] private Transform spawnPos;

    void Start()
    {
        if(GameValues.Difficulty < SpawnThreashold){
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject.Find("SpawnPoint").transform.position = spawnPos.position;
    }
}
