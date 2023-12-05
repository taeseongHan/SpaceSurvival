using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gameManagerTaeseong : MonoBehaviour
{
    public GameObject Alien1;
    public GameObject Player;
    public GameObject Bullet;

    public static gameManagerTaeseong I;
    
    void Awake()
    {
        I = this;
    }


    void Start()
    {
        InvokeRepeating("MakeAlien1", 0.0f, 2f);
        InvokeRepeating("MakeBullet", 0.0f, 0.2f);
    }

    void Update()
    {
       
    }
    void MakeAlien1()
    {

        
            float spawnAngle = Random.Range(0.0f, 360.0f);
            float spawnRadius = Random.Range(10.0f, 11.0f);

            float spawnX = Player.transform.position.x + spawnRadius * Mathf.Cos(spawnAngle * Mathf.Deg2Rad);
            float spawnY = Player.transform.position.y + spawnRadius * Mathf.Sin(spawnAngle * Mathf.Deg2Rad);

            Instantiate(Alien1, new Vector3(spawnX, spawnY, 0), Quaternion.identity);

        
    }

    void MakeBullet()
    {
        float x = Player.transform.position.x;
        float y = Player.transform.position.y;
        Instantiate(Bullet, new Vector3(x, y, 0), Quaternion.identity);
    }

    

}



