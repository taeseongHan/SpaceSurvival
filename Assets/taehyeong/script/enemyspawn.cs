using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public GameObject Enemy;
    public Transform parent;

    float[] rangeX = new float[2];
    float[] rangeY = new float[2];

    public  float maxTime;
    float currenTime;


    void Start()
    {
        currenTime = maxTime;
        rangeX[0] = transform.position.x - transform.localScale.x / 2;
        rangeX[1] = transform.position.x + transform.localScale.x / 2;

        rangeY[0] = transform.position.y - transform.localScale.y / 2;
        rangeY[1] = transform.position.y + transform.localScale.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManagertaehyeong.instance.isPlay)
        {
            if (currenTime > maxTime)
            {
                for (int i = 0; i < 3; i++)
                {
                    GameObject Go = Instantiate(Enemy, parent);
                    Go.transform.position = new Vector3(Random.Range(rangeX[0], rangeX[1]),
                        Random.Range(rangeY[0], rangeY[1]), 0);
                }

                currenTime = 0;
            }
            currenTime += Time.deltaTime;
        }

        
       

    }
}
