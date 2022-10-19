using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static int highScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text highScoreText = this.GetComponent<Text>();
        
        highScoreText.text = "High Score: " + highScore;
    }
}
