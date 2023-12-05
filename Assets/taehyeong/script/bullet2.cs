using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class bullet2 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", 2);




        Vector2 Ien = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float z = Mathf.Atan2(Ien.y, Ien.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, z);


   
    }
     
        void Update()
    {



        if (transform.rotation.y == 0)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        

}

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

   
}

  

