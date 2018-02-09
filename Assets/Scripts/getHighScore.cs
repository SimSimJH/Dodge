using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getHighScore : MonoBehaviour {

    public Text highScoreText;

    private void Start()
    {
        getscore();
    }

    public void getscore()
    {
        var score = PlayerPrefs.GetFloat("HighScore");

        highScoreText.text = score.ToString("F2");
    }
 
}
