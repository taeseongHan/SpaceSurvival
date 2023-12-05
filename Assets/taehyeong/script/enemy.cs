using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Vector2 direction;
    float speed;

    public Transform pos;
    public Vector2 BoxSixe;

    Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        speed = Random.Range(0.5f, 1.0f);

        Invoke("enemyDestory", 11f);
    }


    void Update()
    {
        direction = GameObject.Find("Player").transform.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime);


       
        
          
                Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(pos.position, BoxSixe, 0);
                foreach (Collider2D collider in collider2Ds)
                {
                    if (collider.tag == "Bullet")
                    {
                Destroy(gameObject);
                    }

                }
              

            
        
      
    }
    void enemyDestory()
    {
        Destroy(gameObject);
    }



    public void OnTriggerE2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }





  
   
   
  


  
   
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(pos.position, BoxSixe);
    }
}





  
