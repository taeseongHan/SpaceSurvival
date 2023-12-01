using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-10.0f, 10.0f);
        float y = Random.Range(-10.0f, 10.0f);

        if (!(x > -10 && x < 10) || !(y > -10 && y < 10))
        {
            x = Random.Range(-10.0f, 10.0f);
            y = Random.Range(-10.0f, 10.0f);
        }

        transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
