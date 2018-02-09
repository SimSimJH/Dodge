using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class removeHighScore : MonoBehaviour {

    public Text highScoreText;
	
    public void removeHighscore()
    {
      PlayerPrefs.SetFloat("HighScore", 0);
      PlayerPrefs.Save();

     var score = PlayerPrefs.GetFloat("HighScore");

     highScoreText.text = score.ToString();
    }
	
}
