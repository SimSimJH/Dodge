
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public int hp = 10;
    public Text hpText;

    private void Start()
    {
        hpText.text = hp.ToString();
    }

    private void Update()
    {   

        hpText.text = hp.ToString();
    }
}
