using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text text1;
    void Start()
    {
     text1.text= PlayerPrefs.GetInt("highscore",0).ToString();   
    }

    
}
