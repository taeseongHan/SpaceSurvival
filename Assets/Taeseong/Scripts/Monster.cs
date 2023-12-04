using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Monster : MonoBehaviour
{
    public GameObject Alien1;
    public Transform Player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("MakeAlien1", 0.0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {       
        
        if (Player != null)
        {

            {
                
                Vector3 direction = Player.position - transform.position;
                direction.Normalize();
                transform.Translate(direction * speed * Time.deltaTime);
            }
        }
    }


    void MakeAlien1()
     {

        float spawnAngle = Random.Range(0.0f, 360.0f);
        float spawnRadius = Random.Range(10.0f, 11.0f);

        float spawnX = Player.position.x + spawnRadius * Mathf.Cos(spawnAngle * Mathf.Deg2Rad);
        float spawnY = Player.position.y + spawnRadius * Mathf.Sin(spawnAngle * Mathf.Deg2Rad);


        Instantiate(Alien1, new Vector3(spawnX, spawnY, 0), Quaternion.identity);
       
    }
}
