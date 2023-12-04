using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerJihu : MonoBehaviour
{
    public Time timeTxt;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        // timeTxt.text = time.ToString();
    }
}
