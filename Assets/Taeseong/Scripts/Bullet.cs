using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        // 총알이 위로 쏴지고 일정높이 이상 올라가면 없어지게 하는 코드
        transform.position += new Vector3(0, 0.05f, 0);
        if(transform.position.y > 9.0f)
        {
            Destroy(gameObject);
        }
        
    }   
}
