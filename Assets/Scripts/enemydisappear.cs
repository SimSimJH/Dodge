using UnityEngine;

public class enemydisappear : MonoBehaviour {

    public float startTime;
    public float disappearTime=5.0f;
    public GameObject enemyPrefab;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        if (Time.time-startTime> disappearTime)
        {
            Destroy(enemyPrefab);
        }
    }
}
