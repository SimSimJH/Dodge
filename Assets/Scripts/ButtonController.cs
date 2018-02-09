using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
    public GameObject hpPanel;
    public Text addNumberButtonText; 

	public void OpenMainScene()
    {
        SceneManager.LoadScene("dodge_sim");
    }

    public void ToggleHpPanel()
    {
        hpPanel.SetActive(hpPanel.activeSelf == false);
        //if (hpPanel.activeSelf)
        //{
        //    hpPanel.SetActive(false);
        //} else
        //{
        //    hpPanel.SetActive(true);
        //}
    }

    public void AddNumber()
    {
        var addNumber = PlayerPrefs.GetInt("ADD_NUMBER",1);
        addNumberButtonText.text = (addNumber + 1).ToString();
        PlayerPrefs.SetInt("ADD_NUMBER", addNumber + 1);
        PlayerPrefs.Save();
    }
}
