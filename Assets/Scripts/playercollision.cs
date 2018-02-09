using UnityEngine;

public class playercollision : MonoBehaviour {

    public HP playerHP;
    public float gamestartTime;
    public GameObject explosionPrefab;
    public AudioSource audioSource;
    public GameObject returnButton;
    public float starttime;
    public float endTime;
    

    private void OnTriggerEnter(Collider other)
    {
        

        if (0 < playerHP.hp)
        {
            playerHP.hp--;
            Destroy(other.gameObject);

            //폭발효과 만들기
            var explosion = Instantiate(explosionPrefab);
            explosion.transform.position = other.transform.position;
           
            //폭발음 발생
            PlayExplosionSound();

            //게임오버시 메인메뉴로 돌아가기
            if (playerHP.hp == 0)
            {
                returnButton.SetActive(true);

                StoreHighScore();

            }

        }
        

        
        

    }

    private void Start()
    {
        starttime = Time.time;
        gamestartTime = Time.time;
    }
    private void Update()
    {   
         endTime= Time.time-starttime;
        
        //10초마다 목숨 하나 추가

        if (Time.time - gamestartTime >10.0f)
        {
            if(0 < playerHP.hp)
            {
                playerHP.hp++;

                gamestartTime = Time.time;
            }
        }
        
    }


    public void PlayExplosionSound()
    {
        audioSource.Play();
    }


    //하이스코어 받기
    public void StoreHighScore()
    {
        var score = endTime;
        var score_store = PlayerPrefs.GetFloat("HighScore", 0);


        if (score_store <= score)
        {
            PlayerPrefs.SetFloat("HighScore", score);
            PlayerPrefs.Save();
        }
    }
}
