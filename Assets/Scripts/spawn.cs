using UnityEngine;

public class spawn : MonoBehaviour {

    private float lastSpawnTime; //마지막으로 스폰한 시간
    public float spawnRadius = 1.0f;
    public float spawnInterval = 1.5f; //스폰시간간격
    public GameObject enemyPrefab;
    public GameObject player;

    private void Update()
    {
        if (Time.time - lastSpawnTime > spawnInterval)
        {
            Spawn();

            lastSpawnTime = Time.time;
        }
    }

    private void Spawn()
    {
        var enemy = Instantiate(enemyPrefab);
        var theta = Random.Range(0, 2 * Mathf.PI);
        var spawnPos = spawnRadius * new Vector3(Mathf.Cos(theta), 0, Mathf.Sin(theta));

        enemy.transform.position = player.transform.position + spawnPos;
        
    }
}
