using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class Monster : MonoBehaviour
{

    GameObject player;
    public float speed;
    public int maxHits = 2;
    private int currentHits = 0;



    // Start is called before the first frame update


    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        

            Vector3 direction = player.transform.position - transform.position;
            direction.Normalize();
            transform.Translate(direction * speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(collision.gameObject);
            currentHits++;
            if (currentHits >= maxHits)
            {
                Destroy(gameObject);
            }
        }
    }
}
