using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerJihu : MonoBehaviour
{
    public TMP_Text timeTxt;
    float time;

    private void Update()
    {
        time += Time.deltaTime;
        int min = (int)time % 3600/60;
        int sec = (int)time % 3600%60;
        timeTxt.text = string.Format("{0:D2}:{1:D2}", min, sec);
    }
}
