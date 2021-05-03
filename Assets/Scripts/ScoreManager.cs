using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreDP;
    public int score;

    private void Update(){
        scoreDP.text=score.ToString();
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Obstacle")){
            score++;
            Debug.Log(score);
        }
    }
}
