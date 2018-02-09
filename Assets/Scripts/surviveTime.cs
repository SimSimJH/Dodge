using UnityEngine;
using UnityEngine.UI;

public class surviveTime : MonoBehaviour {

    public float startTime=0.0f;
    public Text surviveText;
    public HP playerHP;
    private float surTime=0.0f;

    private void Start()
    {

        startTime = Time.time;
    }

    private void Update()
    {   
        if (0 < playerHP.hp)
        {
            surTime = Time.time-startTime;
            surviveText.text = surTime.ToString("F2");
        }
    }

}
