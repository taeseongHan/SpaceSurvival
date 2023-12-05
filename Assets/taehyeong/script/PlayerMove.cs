using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float hor;
    float ver;
    public Rigidbody2D rigid;
    public float speed;
   
    void Update()
    {
       
        if (GameManagertaehyeong.instance.isPlay == true)
        {
            hor = Input.GetAxisRaw("Horizontal");

            ver = Input.GetAxis("Vertical");
        }
           
         
        



    }


    private void FixedUpdate()
    {
        rigid.velocity = new Vector2(hor, ver) * speed;
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("enemy와 충돌");
            GameManagertaehyeong.instance.endGame();
        }
    }
}
