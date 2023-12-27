using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroungMusic : MonoBehaviour
{
    private static BackgroungMusic backgroungMusic;

    void Awake(){
        
        if(backgroungMusic == null){
            backgroungMusic = this;
            DontDestroyOnLoad(backgroungMusic);
        }
        else{
            Destroy(gameObject);
        }
    }
}