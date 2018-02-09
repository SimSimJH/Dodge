using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour {

   
    public GameObject player;
    public float speed = 10.0f;
    private void Start()
    {
        player = GameObject.Find("player");//뒤에 플레이어 맞춰줘야함
    }

    public void Update () {

        var diff = player.transform.position - transform.position;
        Vector3 dir = diff.normalized;//unit백터로 만드는것

        transform.Translate(dir*speed*Time.deltaTime);
	}
}
