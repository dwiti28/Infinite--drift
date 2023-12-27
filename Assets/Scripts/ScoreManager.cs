using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{   
    public TMP_Text scoreText;
    private float score;

    // Update is called once per frame
    void Update()
    {
       if(GameObject.FindGameObjectWithTag("Player") != null){
        score += 1 * Time.deltaTime;
        scoreText.text = ((int)score).ToString();
       } 
    }
}
